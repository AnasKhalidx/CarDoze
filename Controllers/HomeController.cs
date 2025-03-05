using CarDoze.Models.Repository;
using Microsoft.AspNetCore.Mvc;
using CarDoze.Areas.Administrator.ViewModels;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using CarDoze.Models;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace CarDoze.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository<Partnership> _partnershipRepository;
        private readonly IRepository<Manufacturer> _manufacturerRepository;
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Company> _companyRepository;
        private readonly IRepository<Review> _reviewRepository;
        private readonly IRepository<CarModels> _carmodelRepository;





        public HomeController(IRepository<Partnership> partnershipRepository, IRepository<Manufacturer> manufacturerRepository, IRepository<Car> carRepository, IRepository<Company> companyRepository, IRepository<Review> reviewRepository, IRepository<CarModels> carmodelRepository)
        {
            _partnershipRepository = partnershipRepository;
            _manufacturerRepository = manufacturerRepository;
            _carRepository = carRepository;
            _companyRepository = companyRepository;
            _reviewRepository = reviewRepository;
            _carmodelRepository = carmodelRepository;
        }
        public async Task<IActionResult> Index()
        {
            var cars = await _carRepository.GetAllAsync();
            var reviews = await _reviewRepository.GetAllActiveAsync();

            var viewModel = new HomePageViewModel
            {
                Cars = cars,
                Reviews = reviews
            };

            return View(viewModel);
        }

        public IActionResult GetRandomCars(int count = 8)
        {
            var randomCars = _carRepository.GetRandomCars(count);
            return Json(randomCars);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Route("/Partnership/{id}")]
        public async Task<IActionResult> Partnership(int id)
        {
            var partnership = await _partnershipRepository.GetByIdAsync(id);
            if (partnership == null)
            {
                return NotFound();
            }

            var companies = await _companyRepository.GetCompaniesByPartnershipIdAsync(id);

            var viewModel = new PartnershipViewModel
            {
                PartnershipID = partnership.PartnershipID,
                TypeShipp = partnership.TypeShipp,
                Companys = companies.Select(company => new CompanyViewModel
                {
                    CompanyID = company.CompanyID,
                    Name = company.Name,
                    Location = company.Location,
                    Description = company.Description,
                    PartnershipID = company.PartnershipID,
                    Logo=company.Logo,
                }).ToList()
            };

            return View(viewModel);
        }
        [HttpGet]
        public async Task<IActionResult> GetManufacturers()
        {
            var manufacturers = await _manufacturerRepository.GetAllAsync();
            if (!manufacturers.Any())
            {
                Console.WriteLine("No manufacturers found"); 
            }
            return Json(manufacturers);
        }
        [HttpGet]
        [Route("/Home/GetModelsByManufacturer/{manufacturerId}")]

        public async Task<JsonResult> GetModelsByManufacturer(int manufacturerId)
        {
            var models = await _carmodelRepository.GetByManufacturerIdAsync(manufacturerId);
            return Json(models);
        }


        [HttpGet]
        public async Task<IActionResult> SearchCars(string name, int? modelID, int? year, decimal? minPrice, decimal? maxPrice, string fuelType, int? manufacturerId)
        {
            Console.WriteLine($"Received manufacturerId: {manufacturerId}");

            var cars = await _carRepository.GetAllCarsWithDetailsAsync();

            if (!string.IsNullOrEmpty(name))
            {
                cars = cars.Where(c => c.Name != null && c.Name.Contains(name));
            }

            if (modelID.HasValue)
            {
                cars = cars.Where(c => c.ModelID == modelID.Value);
            }

            if (year.HasValue)
            {
                cars = cars.Where(c => c.Year == year.Value);
            }

            if (minPrice.HasValue)
            {
                cars = cars.Where(c => c.Price >= minPrice.Value);
            }

            if (maxPrice.HasValue)
            {
                cars = cars.Where(c => c.Price <= maxPrice.Value);
            }

            if (!string.IsNullOrEmpty(fuelType))
            {
                cars = cars.Where(c => c.FuelType == fuelType);
            }

            if (manufacturerId.HasValue)
            {
                cars = cars.Where(c => c.ManufacturerID == manufacturerId.Value);
            }

            cars ??= new List<Car>();

            return View(cars.ToList()); 
        }



        [HttpGet]
        public async Task<IActionResult> Cars(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var car = await _carRepository.GetByIdAsync(id.Value);
            if (car == null)
            {
                return NotFound();
            }

            var partnerships = await _partnershipRepository.GetAllAsync();
            var paymentMethods = new List<Areas.Administrator.ViewModels.PaymentMethod>(); 

            var carViewModel = new CarViewModel
            {
                CarID = car.CarID,
                Name = car.Name,
                Year = car.Year,
                ModelID = car.ModelID,
                Price = car.Price,
                FuelType = car.FuelType,
                ImageURLs = car.ImageURLs ?? new List<string>(), 
                Description = car.Description,
                Manufacturer = new ManufacturerViewModel
                {
                    ManufacturerID = car.Manufacturer.ManufacturerID,
                    Name = car.Manufacturer.Name
                },
                 CarFeatures = car.CarFeatures.Select(cf => new CarCarFeatureViewModel
                 {
                     FeatureID = cf.FeatureID,
                     CarID = cf.CarID,
                     FeatureName = cf.CarFeature.FeatureName
                 }).ToList()
            };
            var partnershipsViewModel = partnerships.Select(p => new PartnershipViewModel
            {
                PartnershipID = p.PartnershipID,
                TypeShipp = p.TypeShipp
            }).ToList();
           
           



            return View("CarDetails", carViewModel); 
        }

        [HttpGet]
        public async Task<IActionResult> GetLatestCars()
        {
            try
            {
                var latestCars = await _carRepository.GetLatestCarsAsync();
                var result = latestCars.Select(car => new CarViewModel
                {
                    CarID = car.CarID,
                    Name = car.Name,
                    Year = car.Year,
                    Price = car.Price,
                    FuelType = car.FuelType,
                    ImageURLs = car.ImageURLs,
                    Description = car.Description,
                    Manufacturer = new ManufacturerViewModel
                    {
                        ManufacturerID = car.Manufacturer.ManufacturerID,
                        Name = car.Manufacturer.Name
                    }
                }).ToList();

                return Json(result);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Failed to fetch latest cars: {ex.Message}");
                return Problem(detail: ex.Message, statusCode: 500);
            }
        }

        [HttpPost]
        public async Task<IActionResult> SubmitCarDetails(int CarID, int PartnershipID, string PaymentMethod)
        {
            return RedirectToAction("ConfirmationPage");
        }
        [HttpGet]
        [Route("/Home/GetModelNameById/{modelId}")]
        public async Task<IActionResult> GetModelNameById(int modelId)
        {
            var model = await _carmodelRepository.GetByIdAsync(modelId);
            if (model == null)
            {
                return NotFound();
            }
            return Json(new { modelName = model.ModelName });
        }




    }


}