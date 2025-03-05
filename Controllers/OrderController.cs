using Microsoft.AspNetCore.Mvc;
using CarDoze.Models;
using CarDoze.Models.Repository;
using CarDoze.Areas.Administrator.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;

[Authorize]
public class OrderController : Controller
{
	private readonly IRepository<Car> _carRepository;
	private readonly IRepository<Partnership> _partnershipRepository;
	private readonly IRepository<Company> _companyRepository;
	private readonly IRepository<Order> _orderRepository;
	private readonly IRepository<ShippingAddress> _shippingAddressRepository;
	private readonly IRepository<Review> _reviewRepository;
	private readonly IEmailSender _emailSender;
	private readonly ILogger<OrderController> _logger;

	public OrderController(IRepository<Car> carRepository,
						   IRepository<Partnership> partnershipRepository,
						   IRepository<Company> companyRepository,
						   IRepository<Order> orderRepository,
						   IRepository<ShippingAddress> shippingAddressRepository,
						   IRepository<Review> reviewRepository,
						   IEmailSender emailSender,
						   ILogger<OrderController> logger)
	{
		_carRepository = carRepository;
		_partnershipRepository = partnershipRepository;
		_companyRepository = companyRepository;
		_orderRepository = orderRepository;
		_shippingAddressRepository = shippingAddressRepository;
		_reviewRepository = reviewRepository;
		_emailSender = emailSender;
		_logger = logger;
	}

	[HttpGet]
	public async Task<IActionResult> CreateOrder(int carId)
	{
		var car = await _carRepository.GetByIdAsync(carId);
		var partnerships = await _partnershipRepository.GetAllAsync();
		var companies = await _companyRepository.GetAllAsync();

		var viewModel = new OrderViewModel
		{
			CarID = carId,
			Car = car,
			TotalPrice = car.Price,
			PaymentMethod = CarDoze.Areas.Administrator.ViewModels.PaymentMethod.CreditCard, // Default selection
			OrderDate = DateTime.Now,
			Partnerships = partnerships.Select(p => new PartnershipViewModel
			{
				PartnershipID = p.PartnershipID,
				TypeShipp = p.TypeShipp,
				Companys = companies.Where(c => c.PartnershipID == p.PartnershipID)
					.Select(c => new CompanyViewModel
					{
						CompanyID = c.CompanyID,
						Name = c.Name,
						// Include other properties as necessary
					}).ToList()
			}).ToList(),
			Companies = companies.Select(c => new CompanyViewModel
			{
				CompanyID = c.CompanyID,
				Name = c.Name,
				// Map other necessary fields
			}).ToList()
		};

		return View(viewModel);
	}

    [HttpPost]
    public async Task<IActionResult> CreateOrder(OrderViewModel model)
    {
        _logger.LogInformation("CreateOrder POST method called for CarID: {CarID}", model.CarID);

        ShippingAddress shippingAddress = new()
        {
            ShippingAddressID = model.ShippingAddressID,
            AddressLine1 = model.ShippingAddress.AddressLine1,
            AddressLine2 = model.ShippingAddress.AddressLine2,
            ZipCode = model.ShippingAddress.ZipCode,
            City = model.ShippingAddress.City,
            Country = model.ShippingAddress.Country,
            State = model.ShippingAddress.State,
/*			ByEmail=model.ByEmail,
*/        };

        await _shippingAddressRepository.AddAsync(shippingAddress);

        if (ModelState.IsValid)
        {
            var order = new Order
            {
                OrderID = model.OrderID,
                CarID = model.CarID,
                OrderDate = model.OrderDate,
                ShippingAddressID = shippingAddress.ShippingAddressID,
                TotalPrice = model.TotalPrice,
                Status = model.Status,
                CreatedBy = User.Identity.Name, 
                CreatedOn = DateTime.Now,
                IsActive = true,
                IsDelete = false,
            };

            await _orderRepository.AddAsync(order);

            try
            {
                var car = await _carRepository.GetByIdAsync(model.CarID);
                string userEmail = User.Identity.Name; 
                List<string> carImages = car.ImageURLs; 
                string subject = "Order Confirmation";

                string body = $@"
                <h1>Order Confirmation</h1>
                <p>Thank you for your order. Here are the details:</p>
                <p>You will deliver your car as soon as possible.</p>
            ";

                _logger.LogInformation("Car image URLs: {ImageURLs}", string.Join(", ", carImages));

                string firstImageUrl = carImages.FirstOrDefault(url => !string.IsNullOrWhiteSpace(url));
                if (!string.IsNullOrWhiteSpace(firstImageUrl))
                {
                    body += $"<img src='{firstImageUrl}' alt='Car Image' /><br/>";
                }
                else
                {
                    _logger.LogWarning("No valid car image URLs found.");
                }

                _logger.LogInformation("Sending email to {Email}", userEmail);
                await _emailSender.SendEmailAsync(userEmail, subject, body);
                _logger.LogInformation("Email sent to {Email}", userEmail);

                ViewBag.Message = "Your order has been submitted successfully. You will receive your car soon.";
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while sending email");
                ViewBag.Message = "Your order has been submitted successfully, but there was an error sending the confirmation email.";
            }

            return View("GiveReview");
        }

        var partnerships = await _partnershipRepository.GetAllAsync();
        var companies = await _companyRepository.GetAllAsync();

        model.Partnerships = partnerships.Select(p => new PartnershipViewModel
        {
            PartnershipID = p.PartnershipID,
            TypeShipp = p.TypeShipp,
            Companys = companies.Where(c => c.PartnershipID == p.PartnershipID)
                .Select(c => new CompanyViewModel
                {
                    CompanyID = c.CompanyID,
                    Name = c.Name,
                }).ToList()
        }).ToList();

        model.Companies = companies.Select(c => new CompanyViewModel
        {
            CompanyID = c.CompanyID,
            Name = c.Name,
        }).ToList();

        return View(model);
    }



    [HttpGet]
	[Route("api/companies/{partnershipId}")]
	public async Task<IActionResult> GetCompaniesByPartnership(int partnershipId)
	{
		var companies = await _companyRepository.GetCompaniesByPartnershipIdAsync(partnershipId);
		return Ok(companies.Select(c => new { companyID = c.CompanyID, name = c.Name }));
	}

	[HttpPost]
	public async Task<IActionResult> GiveReview(ReviewViewModel model)
	{
		if (ModelState.IsValid)
		{
			var review = new Review
			{
				CreatedBy = User.Identity.Name,
				CreatedOn = DateTime.Now,
				IsActive = false,
				IsDelete = false,
				Rating = model.Rating,
				Comment = model.Comment
			};

			await _reviewRepository.AddAsync(review);
			return RedirectToAction("Index", "Home");
		}

		return View(model); 
	}

	[HttpGet]
	public IActionResult GiveReview()
	{
		var model = new ReviewViewModel();
		return View("~/Views/Order/GiveReview.cshtml", model);
	}
}