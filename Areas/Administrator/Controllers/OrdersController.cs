using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CarDoze.Models.Repository;
using CarDoze.Areas.Administrator.ViewModels;
using System.Linq;
using CarDoze.Models;

namespace CarDoze.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class OrdersController : Controller
    {
        private readonly IRepository<Order> _orderRepository;

        public OrdersController(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        [Route("/Orders/Index")]
        public async Task<IActionResult> Index()
        {
            var orders = await _orderRepository.GetAllWithDetailsAsync();
            if (orders == null)
            {
                return View("Error", new ErrorViewModel { RequestId = "Orders not found" });
            }

            var orderViewModels = orders.Select(order => new OrderViewModel
            {
                OrderID = order.OrderID,
                OrderDate = order.OrderDate,
                Status = order.Status,
                ShippingAddressID = order.ShippingAddressID,
                PaymentMethodID = order.PaymentMethod.ToString(), 
                TotalPrice = order.Car.Price,
                Car = order.Car,
                ShippingAddress = order.ShippingAddress != null ? new ShippingAddressViewModel 
                {
                    AddressLine1 = order.ShippingAddress.AddressLine1,
                    AddressLine2 = order.ShippingAddress.AddressLine2,
                    City = order.ShippingAddress.City,
                    State = order.ShippingAddress.State,
                    Country = order.ShippingAddress.Country,
                    ZipCode = order.ShippingAddress.ZipCode
                } : null,
                PaymentMethod = (ViewModels.PaymentMethod)order.PaymentMethod, 
                CreatedBy = order.CreatedBy 
            }).ToList();

            return View(orderViewModels);
        }
    }
}
