using CarDoze.Areas.Administrator.ViewModels;
using CarDoze.Models;
using CarDoze.Models.Repository;
using CarDoze.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CarDoze.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class CarsController : Controller
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Manufacturer> _manufacturerRepository;
        private readonly IRepository<CarModels> _carModelRepository;
        private readonly IRepository<CarCarFeature> _carCarFeatureRepository;
        private readonly IRepository<CarFeature> _carFeatureRepository;
        private readonly CarDozeDbContext _context;

        public CarsController(IRepository<Car> carRepository, IRepository<Manufacturer> manufacturerRepository, IRepository<CarModels> carModelRepository, IRepository<CarCarFeature> carCarFeatureRepository, IRepository<CarFeature> carFeatureRepository, CarDozeDbContext context)
        {
            _carRepository = carRepository;
            _manufacturerRepository = manufacturerRepository;
            _carModelRepository = carModelRepository;
            _carCarFeatureRepository = carCarFeatureRepository;
            _carFeatureRepository = carFeatureRepository;
            _context = context;
        }

        [HttpGet]
        [Route("/Cars/Index")]
        public async Task<IActionResult> Index()
        {
            var cars = await _context.Cars
                .Include(c => c.Manufacturer)
                .Include(c => c.CarFeatures)
                .ThenInclude(cf => cf.CarFeature)
                .ToListAsync();

            var carModels = await _context.carModels.ToListAsync();

            var carViewModels = cars.Select(c => new CarViewModel
            {
                CarID = c.CarID,
                Name = c.Name,
                Year = c.Year,
                Price = c.Price,
                FuelType = c.FuelType,
                ImageURLs = c.ImageURLs ?? new List<string>(), 
                Description = c.Description,
                ModelID = c.ModelID,
                Manufacturer = new ManufacturerViewModel
                {
                    ManufacturerID = c.Manufacturer.ManufacturerID,
                    Name = c.Manufacturer.Name
                },
                CarFeatures = c.CarFeatures.Select(cf => new CarCarFeatureViewModel
                {
                    FeatureName = cf.CarFeature.FeatureName
                }).ToList()
            }).ToList();

            return View(carViewModels);
        }


        [HttpGet]
        [Route("/Cars/Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();

            var car = await _carRepository.GetByIdAsync(id.Value);
            if (car == null) return NotFound();

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
                    ManufacturerID = car.ManufacturerID,
                    Name = car.Manufacturer.Name
                },
                CarFeatures = car.CarFeatures.Select(cf => new CarCarFeatureViewModel
                {
                    FeatureID = cf.FeatureID,
                    CarID = cf.CarID,
                    FeatureName = cf.CarFeature.FeatureName
                }).ToList()
            };

            return View(carViewModel);
        }

        [HttpGet]
        [Route("/Cars/Create")]
        public async Task<IActionResult> Create()
        {
            await PopulateDropDowns();
            return View(new CarViewModel());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Cars/Create")]
        public async Task<IActionResult> Create(CarViewModel carViewModel, [FromForm] List<int> Features)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var car = new Car
                    {
                        Name = carViewModel.Name,
                        ManufacturerID = carViewModel.Manufacturer.ManufacturerID,
                        ModelID = carViewModel.ModelID,
                        Year = carViewModel.Year,
                        Price = carViewModel.Price,
                        FuelType = carViewModel.FuelType,
                        ImageURLs = carViewModel.ImageURLs,
                        Description = carViewModel.Description,
                        CreatedBy = User.Identity.Name,
                        CreatedOn = DateTime.Now,
                        IsActive = true,
                        IsDelete = false
                    };

                    await _carRepository.AddAsync(car);
                    await _context.SaveChangesAsync();
                    var selectedFeatureIds = Request.Form["Features"];
                    if (!string.IsNullOrEmpty(selectedFeatureIds))
                    {
                        foreach (var featureId in selectedFeatureIds)
                        {
                            var featureName = _carFeatureRepository.GetFeatureNameByIdAsync(Convert.ToInt32(featureId)).Result;

                            var carCarFeature = new CarCarFeature
                            {
                                CarID = car.CarID,
                                FeatureID = Convert.ToInt32(featureId),
                                FeatureName = featureName,
                            };

                            _carCarFeatureRepository.AddAsync(carCarFeature).Wait();
                        }
                    }

                    await _context.SaveChangesAsync();

                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while saving the entity changes: " + ex.Message);
                    if (ex.InnerException != null)
                    {
                        Console.WriteLine("Inner Exception: " + ex.InnerException.Message);
                    }

                    ModelState.AddModelError(string.Empty, "An error occurred while saving the entity changes. Please try again.");
                }
            }

            await PopulateDropDowns();
            return View(carViewModel);
        }



        [HttpGet]
        [Route("/Cars/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var carFeatures = _carFeatureRepository.GetAllAsync().Result;

            if (carFeatures != null && carFeatures.Any())
            {
                var carFeatureOptions = carFeatures.Select(cf => new SelectListItem
                {
                    Value = cf.CarFeatureID.ToString(),
                    Text = cf.FeatureName
                }).ToList();

                ViewBag.CarFeatureIDs = carFeatureOptions;
            }
            else
            {
                ViewBag.CarFeatureIDs = new List<SelectListItem>(); 
            }
            var car = await _carRepository.GetByIdAsync(id.Value);
            var carFeaturesa = await _carCarFeatureRepository.GetByCarIdAsync(id.Value);

            if (car == null) return NotFound();

            var carViewModel = new CarViewModel
            {
                CarID = car.CarID,
                Name = car.Name,
                Year = car.Year,
                Price = car.Price,
                ModelID = car.ModelID,
                FuelType = car.FuelType,
                ImageURLs = car.ImageURLs,
                Description = car.Description,
                Manufacturer = new ManufacturerViewModel
                {
                    ManufacturerID = car.ManufacturerID,
                    Name = car.Manufacturer.Name
                },
                CarFeatures = car.CarFeatures.Select(cf => new CarCarFeatureViewModel
                {
                    FeatureID = cf.FeatureID,
                    CarID = cf.CarID,
                    FeatureName = cf.CarFeature.FeatureName
                }).ToList()
            };

            await PopulateDropDowns();

            var models = await _carModelRepository.GetByManufacturerIdAsync(car.ManufacturerID);
            if (models == null || !models.Any())
            {
                models = new List<CarModels>(); 
            }
            ViewBag.Models = new SelectList(models, "ModelsID", "ModelName", car.ModelID);

            return View(carViewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Cars/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, CarViewModel carViewModel)
        {
            if (id != carViewModel.CarID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                var manufacturers = _carRepository.GetAllAsync().Result;
                ViewBag.ManufacturerName = new SelectList(manufacturers, "ManufacturerID", "Name");
                return View(carViewModel);
            }

            var carToUpdate = await _carRepository.GetByIdAsync(id);
            if (carToUpdate == null)
            {
                return NotFound();
            }

           
            carToUpdate.Name = carViewModel.Name;
            carToUpdate.ModelID = carViewModel.ModelID;
            carToUpdate.Year = carViewModel.Year;
            carToUpdate.Price = carViewModel.Price;
            carToUpdate.FuelType = carViewModel.FuelType;
            carToUpdate.ImageURLs = carViewModel.ImageURLs;
            carToUpdate.Description = carViewModel.Description;
            carToUpdate.ModifiedBy = User.Identity.Name;
            carToUpdate.ModifiedOn = DateTime.Now;
            carToUpdate.IsActive = carViewModel.IsActive; 
            carToUpdate.IsDelete = carViewModel.IsDelete;  
            carToUpdate.ManufacturerID = carViewModel.Manufacturer.ManufacturerID;


            var removedFeatureIds = Request.Form["RemovedFeatures"].ToString().Split(',', StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse).Distinct();

            foreach (var featureId in removedFeatureIds)
            {
                var featureToRemove = await _carCarFeatureRepository.FindByCarIdAndFeatureId(carViewModel.CarID, featureId);
                if (featureToRemove != null)
                {
                    await _carCarFeatureRepository.DeleteAsync(featureToRemove);
                }
            }


            List<int> selectedFeatureIds = new List<int>();
            if (Request.Form["Features"].Count > 0 && !string.IsNullOrEmpty(Request.Form["Features"]))
            {
                var featureIds = Request.Form["Features"].ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var featureId in featureIds)
                {
                    if (int.TryParse(featureId, out int parsedId))
                    {
                        selectedFeatureIds.Add(parsedId);
                    }
                    else
                    {
                        ModelState.AddModelError("Features", $"Invalid feature ID: {featureId}");
                    }
                }
            }

            await UpdateCarFeatures(carToUpdate, selectedFeatureIds);

            try
            {
                await _carRepository.UpdateAsync(carToUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ModelState.AddModelError("", "A concurrency error occurred. Please try again. " + ex.Message);
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "An error occurred while updating the data: " + ex.InnerException?.Message);
            }

            ViewBag.ManufacturerName = new SelectList(await _carRepository.GetAllAsync(), "ManufacturerID", "Name");
            return View(carViewModel);
        }

        private async Task UpdateCarFeatures(Car carToUpdate, List<int> selectedFeatureIds)
        {
            var currentFeatures = await _carCarFeatureRepository.GetByCarIdAsync(carToUpdate.CarID);

            var featuresToAdd = selectedFeatureIds.Except(currentFeatures.Select(cf => cf.FeatureID)).ToList();

            var featuresToRemove = currentFeatures.Where(cf => !selectedFeatureIds.Contains(cf.FeatureID)).ToList();

            foreach (var featureId in featuresToAdd)
            {
                var featureName = await _carFeatureRepository.GetFeatureNameByIdAsync(featureId);
                var newFeature = new CarCarFeature { CarID = carToUpdate.CarID, FeatureID = featureId, FeatureName = featureName };
                await _carCarFeatureRepository.AddAsync(newFeature);
            }

            foreach (var feature in featuresToRemove)
            {
                await _carCarFeatureRepository.DeleteAsync(feature);
            }
        }


        [HttpGet]
        [Route("/Cars/GetModelsByManufacturer/{manufacturerId}")]
        public async Task<JsonResult> GetModelsByManufacturer(int manufacturerId)
        {
            var models = await _carModelRepository.GetByManufacturerIdAsync(manufacturerId);
            return Json(models);
        }

        [Route("/Cars/Delete/{id}")]
        // GET: Administrator/Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

            var carViewModel = new CarViewModel
            {
                CarID = car.CarID,
                Name = car.Name,
                ModelID = car.ModelID,
                Year = car.Year,
                Price = car.Price,
                FuelType = car.FuelType,
                ImageURLs = car.ImageURLs,
                Description = car.Description,
                Manufacturer = car.Manufacturer == null ? null : new ManufacturerViewModel
                {
                    ManufacturerID = car.Manufacturer.ManufacturerID,
                    Name = car.Manufacturer.Name
                }
            };

            return View(carViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        // POST: Administrator/Cars/Delete/5
        [Route("/Cars/Delete/{id}")]

        public IActionResult DeleteConfirmed(int id)
        {
            var car = _carRepository.GetByIdAsync(id).Result;
            if (car != null)
            {
                _carRepository.DeleteAsync(car).Wait();
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task PopulateDropDowns()
        {
            var manufacturers = await _manufacturerRepository.GetAllAsync();
            ViewBag.Manufacturers = new SelectList(manufacturers, "ManufacturerID", "Name");

            var carFeatures = await _carFeatureRepository.GetAllAsync();
            ViewBag.CarFeatureIDs = new SelectList(carFeatures, "CarFeatureID", "FeatureName");

            var models = await _carModelRepository.GetAllAsync();
            ViewBag.Models = new SelectList(models, "ModelsID", "ModelName");
        }
        [HttpGet]
        [Route("/Cars/GetModelNameById/{modelId}")]
        public async Task<IActionResult> GetModelNameById(int modelId)
        {
            var model = await _carModelRepository.GetByIdAsync(modelId);
            if (model == null)
            {
                return NotFound();
            }
            return Json(new { modelName = model.ModelName });
        }

    }

}
