using CarDoze.Areas.Administrator.ViewModels;
using CarDoze.Models;
using CarDoze.Models.Repository;
using CarDoze.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CarDoze.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class ManufacturersController : Controller
    {
        private readonly IRepository<Manufacturer> _manufacturerRepository;
        private readonly IRepository<CarModels> _carModelRepository;
        private readonly CarDozeDbContext _context;

        public ManufacturersController(IRepository<Manufacturer> manufacturerRepository, IRepository<CarModels> carModelsRepository, CarDozeDbContext context)
        {
            _manufacturerRepository = manufacturerRepository;
            _carModelRepository = carModelsRepository;
            _context = context;
        }

        [Route("/Manufacturers/Index")]
        public async Task<IActionResult> Index()
        {
            var manufacturers = await _context.Manufacturers
                                              .Include(m => m.Models)
                                              .Where(m => !m.IsDelete)
                                              .ToListAsync();

            var manufacturerViewModels = manufacturers.Select(m => new ManufacturerViewModel
            {
                ManufacturerID = m.ManufacturerID,
                Name = m.Name,
                Logo = m.Logo,
                Description = m.Description,
                CarModels = m.Models?.Where(cm => !cm.IsDelete).Select(cm => new CarModelViewModel
                {
                    ModelsID = cm.ModelsID,
                    ModelName = cm.ModelName,
                    ManufacturerID = cm.ManufacturerID,
                    IsDelete = cm.IsDelete
                }).ToList()
            });

            return View(manufacturerViewModels);
        }



        [Route("/Manufacturers/Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturer = await _manufacturerRepository.GetByIdAsync(id.Value);
            if (manufacturer == null)
            {
                return NotFound();
            }

            var manufacturerViewModel = new ManufacturerViewModel
            {
                ManufacturerID = manufacturer.ManufacturerID,
                Name = manufacturer.Name,
                Logo = manufacturer.Logo,
                Description = manufacturer.Description
            };

            return View(manufacturerViewModel);
        }

        [HttpGet]
        [Route("/Manufacturers/Create")]
        public IActionResult Create()
        {
            var viewModel = new ManufacturerViewModel();
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Manufacturers/Create")]
        public async Task<IActionResult> Create(ManufacturerViewModel manufacturerViewModel)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var manufacturer = new Manufacturer
                    {
                        Name = manufacturerViewModel.Name,
                        Logo = manufacturerViewModel.Logo,
                        Description = manufacturerViewModel.Description,
                        CreatedBy = User.Identity.Name,
                        CreatedOn = DateTime.Now,
                        ModifiedOn = DateTime.Now,
                        IsActive = true,
                        IsDelete = false,
                        Models = new List<CarModels>() 
                    };

                    await _manufacturerRepository.AddAsync(manufacturer);
                    await _context.SaveChangesAsync();

                    if (manufacturerViewModel.CarModels != null)
                    {
                        foreach (var carModelViewModel in manufacturerViewModel.CarModels)
                        {
                            var carModel = new CarModels
                            {
                                ModelName = carModelViewModel.ModelName,
                                ManufacturerID = manufacturer.ManufacturerID, 
                                CreatedBy = User.Identity.Name,
                                CreatedOn = DateTime.Now,
                                ModifiedOn = DateTime.Now,
                                IsActive = true,
                                IsDelete = false,
                            };
                            manufacturer.Models.Add(carModel);
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

            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    Console.WriteLine($"Key: {state.Key}, Error: {error.ErrorMessage}, Exception: {error.Exception}");
                }
            }

            return View(manufacturerViewModel);
        }




        [HttpGet]
        [Route("/Manufacturers/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturer = await _context.Manufacturers
                                             .Include(m => m.Models)
                                             .FirstOrDefaultAsync(m => m.ManufacturerID == id);

            if (manufacturer == null)
            {
                return NotFound();
            }

            var manufacturerViewModel = new ManufacturerViewModel
            {
                ManufacturerID = manufacturer.ManufacturerID,
                Name = manufacturer.Name,
                Logo = manufacturer.Logo,
                Description = manufacturer.Description,
                CarModels = manufacturer.Models?.Where(cm => !cm.IsDelete).Select(cm => new CarModelViewModel
                {
                    ModelsID = cm.ModelsID,
                    ModelName = cm.ModelName,
                    ManufacturerID = cm.ManufacturerID,
                    IsDelete = cm.IsDelete
                }).ToList()
            };

            return View(manufacturerViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Manufacturers/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, ManufacturerViewModel manufacturerViewModel)
        {
            if (id != manufacturerViewModel.ManufacturerID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var manufacturer = await _context.Manufacturers
                                                 .Include(m => m.Models)
                                                 .FirstOrDefaultAsync(m => m.ManufacturerID == id);

                if (manufacturer == null)
                {
                    return NotFound();
                }

                manufacturer.Name = manufacturerViewModel.Name;
                manufacturer.Logo = manufacturerViewModel.Logo;
                manufacturer.Description = manufacturerViewModel.Description;
                manufacturer.ModifiedBy = User.Identity.Name;
                manufacturer.ModifiedOn = DateTime.Now;

                if (manufacturerViewModel.CarModels != null)
                {
                    var carModelIdsInViewModel = manufacturerViewModel.CarModels.Select(cm => cm.ModelsID).ToList();

                    foreach (var carModelViewModel in manufacturerViewModel.CarModels)
                    {
                        var existingCarModel = manufacturer.Models.FirstOrDefault(cm => cm.ModelsID == carModelViewModel.ModelsID);

                        if (carModelViewModel.IsDelete)
                        {
                            if (existingCarModel != null)
                            {
                                existingCarModel.IsDelete = true;
                                existingCarModel.ModifiedBy = User.Identity.Name;
                                existingCarModel.ModifiedOn = DateTime.Now;
                            }
                        }
                        else
                        {
                            if (existingCarModel != null)
                            {
                                existingCarModel.ModelName = carModelViewModel.ModelName;
                                existingCarModel.ModifiedBy = User.Identity.Name;
                                existingCarModel.ModifiedOn = DateTime.Now;
                            }
                            else
                            {
                                var newCarModel = new CarModels
                                {
                                    ModelName = carModelViewModel.ModelName,
                                    ManufacturerID = manufacturer.ManufacturerID,
                                    IsActive = true,
                                    IsDelete = false,
                                    CreatedBy = User.Identity.Name,
                                    CreatedOn = DateTime.Now,
                                    ModifiedOn = DateTime.Now
                                };
                                manufacturer.Models.Add(newCarModel);
                            }
                        }
                    }
                }

                _context.Update(manufacturer);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }

            foreach (var state in ModelState)
            {
                foreach (var error in state.Value.Errors)
                {
                    Console.WriteLine($"Key: {state.Key}, Error: {error.ErrorMessage}, Exception: {error.Exception}");
                }
            }

            return View(manufacturerViewModel);
        }





        [Route("/Manufacturers/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturer = await _manufacturerRepository.GetByIdAsync(id.Value);
            if (manufacturer == null)
            {
                return NotFound();
            }

            var manufacturerViewModel = new ManufacturerViewModel
            {
                ManufacturerID = manufacturer.ManufacturerID,
                Name = manufacturer.Name,
                Logo = manufacturer.Logo,
                Description = manufacturer.Description
            };

            return View(manufacturerViewModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("/Manufacturers/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var manufacturer = await _manufacturerRepository.GetByIdAsync(id);
            if (manufacturer != null)
            {
                await _manufacturerRepository.DeleteAsync(manufacturer);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
