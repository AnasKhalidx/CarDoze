using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarDoze.Models.Repository;
using CarDoze.Areas.Administrator.ViewModels;
using CarDoze.Models;

namespace CarDoze.Controllers
{
    public class UserController : Controller
    {
        private readonly WishlistRepository _wishlistRepository;
        private readonly CarRepository _carRepository;

        public UserController(WishlistRepository wishlistRepository, CarRepository carRepository)
        {
            _wishlistRepository = wishlistRepository;
            _carRepository = carRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Wishlist()
        {
            // Get the wishlists asynchronously
            var wishlists = await _wishlistRepository.GetAllAsync();

            return View(wishlists);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CompareCars(int[] carIds)
        {
            if (carIds == null || carIds.Length < 2)
            {
                // Handle error if less than two cars are selected for comparison
                return RedirectToAction(nameof(Wishlist));
            }

            var selectedCars = new List<Car>();
            foreach (var carId in carIds)
            {
                // Retrieve car asynchronously
                var car = await _carRepository.GetByIdAsync(carId);
                if (car != null)
                {
                    selectedCars.Add(car);
                }
            }

            // Pass the selected cars to the view
            return View(selectedCars);
        }
    }
}
