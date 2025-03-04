using System;
using System.Linq;
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
    public class PartnershipsController : Controller
    {
        private readonly IRepository<Partnership> _partnershipRepository;

        public PartnershipsController(IRepository<Partnership> partnershipRepository)
        {
            _partnershipRepository = partnershipRepository;
        }

        // GET: Administrator/Partnerships
        [Route("/Partnership/Index")]
        public async Task<IActionResult> Index()
        {
            var partnerships = await _partnershipRepository.GetAllAsync();
            var partnershipViewModels = partnerships.Select(p => new PartnershipViewModel
            {
                PartnershipID = p.PartnershipID,
                TypeShipp = p.TypeShipp,
                Logo = p.Logo,
                Description = p.Description,
            });
            return View(partnershipViewModels);
        }

        // GET: Administrator/Partnerships/Details/5
        [Route("/Partnership/Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partnership = await _partnershipRepository.GetByIdAsync(id.Value);
            if (partnership == null)
            {
                return NotFound();
            }

            var partnershipViewModel = new PartnershipViewModel
            {
                PartnershipID = partnership.PartnershipID,
                TypeShipp = partnership.TypeShipp,
                Description = partnership.Description,
                Logo= partnership.Logo,
            };

            return View(partnershipViewModel);
        }

        // GET: Administrator/Partnerships/Create
        [Route("/Partnership/Create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administrator/Partnerships/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Partnership/Create")]
        public async Task<IActionResult> Create(PartnershipViewModel partnershipViewModel)
        {
            if (ModelState.IsValid)
            {
                var partnership = new Partnership
                {
                    TypeShipp = partnershipViewModel.TypeShipp,
                    Description= partnershipViewModel.Description,
                    Logo= partnershipViewModel.Logo,
                    CreatedBy = User.Identity.Name, 
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                };

                await _partnershipRepository.AddAsync(partnership);
                return RedirectToAction(nameof(Index));
            }
            return View(partnershipViewModel);
        }

        // GET: Administrator/Partnerships/Edit/5
        [Route("/Partnership/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partnership = await _partnershipRepository.GetByIdAsync(id.Value);
            if (partnership == null)
            {
                return NotFound();
            }

            var partnershipViewModel = new PartnershipViewModel
            {
                PartnershipID = partnership.PartnershipID,
                TypeShipp = partnership.TypeShipp,
                Logo = partnership.Logo,
                Description = partnership.Description,
            };

            return View(partnershipViewModel);
        }

        // POST: Administrator/Partnerships/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Partnership/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, PartnershipViewModel partnershipViewModel)
        {
            if (id != partnershipViewModel.PartnershipID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var partnership = new Partnership
                {
                    PartnershipID = partnershipViewModel.PartnershipID,
                    CreatedBy  = User.Identity.Name,
					TypeShipp = partnershipViewModel.TypeShipp,
                    Logo = partnershipViewModel.Logo,
                    Description = partnershipViewModel.Description,
                    ModifiedBy = User.Identity.Name, 
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                };

                try
                {
                    await _partnershipRepository.UpdateAsync(partnership);
                }
                catch
                {
                    if (!(await _partnershipRepository.GetAllAsync()).Any(p => p.PartnershipID == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(partnershipViewModel);
        }

        // GET: Administrator/Partnerships/Delete/5
        [Route("/Partnership/Delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var partnership = await _partnershipRepository.GetByIdAsync(id.Value);
            if (partnership == null)
            {
                return NotFound();
            }
              var partnershipViewModel = new PartnershipViewModel
            {
                PartnershipID = partnership.PartnershipID,
                TypeShipp = partnership.TypeShipp,
                Logo  = partnership.Logo,
                Description=partnership.Description,
            };

            return View(partnershipViewModel);
        }

        // POST: Administrator/Partnerships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("/Partnership/Delete/{id}")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var partnership = await _partnershipRepository.GetByIdAsync(id);
            if (partnership != null)
            {
                await _partnershipRepository.DeleteAsync(partnership);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
