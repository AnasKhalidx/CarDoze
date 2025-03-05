using Microsoft.AspNetCore.Mvc;
using CarDoze.Models;
using CarDoze.Areas.Administrator.ViewModels;
using CarDoze.Models.Repository;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using CarDoze.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace CarDoze.Controllers
{
    [Authorize]
    public class WishlistController : Controller
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Wishlist> _wishlistRepository;
        private readonly UserManager<IdentityUser> _userManager;

        public WishlistController(IRepository<Car> carRepository, IRepository<Wishlist> wishlistRepository, UserManager<IdentityUser> userManager)
        {
            _carRepository = carRepository;
            _wishlistRepository = wishlistRepository;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Challenge();
            }

            var wishlists = await _wishlistRepository.GetAllByUserIdAsync(user.Id);

            var carViewModels = new List<CarViewModel>();
            foreach (var wishlist in wishlists)
            {
                var car = await _carRepository.GetByIdAsync(wishlist.CarID);
                if (car != null)
                {
                    var carViewModel = new CarViewModel
                    {
                        CarID = car.CarID,
                        Name = car.Name,
                        Year = car.Year,
                        Price = car.Price,
                        FuelType = car.FuelType,
                        ImageURLs = car.ImageURLs,
                        Description = car.Description,
                        ModelID = car.ModelID,
                        Manufacturer = new ManufacturerViewModel
                        {
                            ManufacturerID = car.Manufacturer.ManufacturerID,
                            Name = car.Manufacturer.Name,
                            Logo = car.Manufacturer.Logo,
                            Description = car.Manufacturer.Description
                        },
                        CarFeatures = car.CarFeatures.Select(cf => new CarCarFeatureViewModel
                        {
                            CarID = cf.CarID,
                            FeatureID = cf.FeatureID,
                            FeatureName = cf.CarFeature.FeatureName
                        }).ToList(),
                        Models = car.Models.Select(m => new CarModelViewModel
                        {
                            ModelsID = m.ModelsID,
                            ModelName = m.ModelName,
                            ManufacturerID = m.ManufacturerID
                        }).ToList()
                    };
                    carViewModels.Add(carViewModel);
                }
            }

            var viewModel = new WishlistViewModel
            {
                Cars = carViewModels
            };

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddToWishlist(int carId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Json(new { success = false, message = "User not authenticated." });
            }

            var car = await _carRepository.GetByIdAsync(carId);
            if (car == null)
            {
                return Json(new { success = false, message = "Car not found." });
            }

            var wishlist = new Wishlist
            {
                CarID = car.CarID,
                CreatedBy = user.Id,
                CreatedOn = DateTime.Now,
                IsActive = true,
                IsDelete = false
            };

            await _wishlistRepository.AddAsync(wishlist);

            return Json(new { success = true, message = $"Car {car.CarID} added to wishlist!" });
        }
        [HttpPost]
        public async Task<IActionResult> RemoveFromWishlist(int carId)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return Json(new { success = false, message = "User not authenticated." });
            }

            var wishlists = await _wishlistRepository.GetAllByUserIdAsync(user.Id);
            var itemToRemove = wishlists.FirstOrDefault(w => w.CarID == carId);
            if (itemToRemove == null)
            {
                return Json(new { success = false, message = "Car not found in wishlist." });
            }

            await _wishlistRepository.DeleteAsync(itemToRemove);

            return RedirectToAction("Index");
        }

    }

}