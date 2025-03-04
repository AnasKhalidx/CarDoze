using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using CarDoze.Models.Repository;
using CarDoze.Areas.Administrator.ViewModels;
using CarDoze.Models;

namespace CarDoze.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class CarFeaturesController : Controller
    {
        private readonly IRepository<CarFeature> _carFeatureRepository;
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<CarCarFeature> _carCarFeatureRepository;


        public CarFeaturesController(
            IRepository<CarFeature> carFeatureRepository,
            IRepository<Car> carRepository,IRepository<CarCarFeature> carCarFeature)
        {
            _carFeatureRepository = carFeatureRepository;
            _carRepository = carRepository;
            _carCarFeatureRepository=carCarFeature;
        }

        // GET: /Administrator/CarFeatures/Index
        [Route("CarFeatures/Index")]
        public async Task<IActionResult> Index()
        {
            var carFeatures = await _carFeatureRepository.GetAllAsync();
            var carFeaturesViewModel = carFeatures.Select(c => new CarFeatureViewModel
            {
                CarFeatureID = c.CarFeatureID,
                FeatureName = c.FeatureName,
                
            }).ToList();

            return View(carFeaturesViewModel);
        }
        // GET: /Administrator/CarFeatures/Create
        [Route("CarFeatures/Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CarFeatures/Create")]
        public async Task<IActionResult> Create(CarFeatureViewModel carFeatureViewModel)
        {
            if (ModelState.IsValid)
            {
                var carFeature = new CarFeature
                {
                    FeatureName = carFeatureViewModel.FeatureName,
                    CreatedBy = User.Identity.Name,
                    CreatedOn = DateTime.Now,
                    IsActive = true,
                    IsDelete = false,
                   
                };
                ViewBag.Cars = _carRepository.GetAllAsync().Result
               .Select(c => new { c.CarID, c.Name }).ToList();
               


                await _carFeatureRepository.AddAsync(carFeature);
                foreach (var carCarFeatureViewModel in carFeatureViewModel.Cars)
                {
                    var carCarFeature = new CarCarFeature
                    {
                        FeatureID = carFeature.CarFeatureID,
                        CarID = carCarFeatureViewModel.CarID,
                        FeatureName= carCarFeatureViewModel.FeatureName,
                    };

                    await _carCarFeatureRepository.AddAsync(carCarFeature);
                }

                TempData["Success"] = "Feature created successfully.";
                return RedirectToAction(nameof(Index));
            }
            return View(carFeatureViewModel);
        }

        // GET: /Administrator/CarFeatures/Edit/{id}
        [Route("CarFeatures/Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var carFeature = await _carFeatureRepository.GetByIdAsync(id);
            if (carFeature == null)
            {
                return NotFound();
            }

            var carFeature2 = new CarFeatureViewModel
            {
                CarFeatureID = carFeature.CarFeatureID,
                FeatureName = carFeature.FeatureName,

            };
           

            return View(carFeature2);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CarFeatures/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, CarFeatureViewModel carFeatureViewModel)
        {
            if (id != carFeatureViewModel.CarFeatureID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var carFeature = await _carFeatureRepository.GetByIdAsync(id);
                if (carFeature == null)
                {
                    return NotFound();
                }

                carFeature.FeatureName = carFeatureViewModel.FeatureName;
                carFeature.ModifiedBy = User.Identity.Name;
                carFeature.ModifiedOn = DateTime.Now;

                await _carFeatureRepository.UpdateAsync(carFeature);
                TempData["Success"] = "Feature updated successfully.";
                return RedirectToAction(nameof(Index));
            }
            return View(carFeatureViewModel);
        }

        // GET: /Administrator/CarFeatures/Delete/{id}
        [Route("CarFeatures/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var carFeature = await _carFeatureRepository.GetByIdAsync(id);
            if (carFeature == null)
            {
                return NotFound();
            }
            var carFeature2 = new CarFeatureViewModel
            {
                CarFeatureID = carFeature.CarFeatureID,
                FeatureName = carFeature.FeatureName,

            };


            return View(carFeature2);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("CarFeatures/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var carFeature = await _carFeatureRepository.GetByIdAsync(id);
            if (carFeature != null)
            {
                await _carFeatureRepository.DeleteAsync(carFeature);
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}
