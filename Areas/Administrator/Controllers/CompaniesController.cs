using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarDoze.Areas.Administrator.ViewModels;
using CarDoze.Models;
using CarDoze.Models.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.CodeAnalysis;
using System.ComponentModel.Design;
using System.Xml.Linq;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CarDoze.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class CompaniesController : Controller
    {
        private readonly IRepository<Company> _companyRepository;
        private readonly IRepository<Partnership> _partnershipRepository;

        public CompaniesController(IRepository<Company> companyRepository, IRepository<Partnership> partnershipRepository)
        {
            _companyRepository = companyRepository;
            _partnershipRepository = partnershipRepository;
        }

        // GET: Administrator/Companies
        [Route("/Companies/Index")]
        public async Task<IActionResult> Index()
        {
            var companies = await _companyRepository.GetAllAsync();
            var companyViewModels = companies.Select(c => new CompanyViewModel
            {
                CompanyID = c.CompanyID,
                Name = c.Name,
                Location = c.Location,
                Description = c.Description,
                Logo = c.Logo,
                
                PartnershipID = c.PartnershipID,
                Partnerships = new PartnershipViewModel 
                {
                    PartnershipID = c.Partnerships.PartnershipID,
                    TypeShipp = c.Partnerships.TypeShipp,
                    Logo=c.Partnerships.Logo,
                    Description=c.Partnerships.Description,
                }
            });
            return View(companyViewModels);
        }

        // GET: Administrator/Companies/Details/5
        [Route("/Companies/Details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _companyRepository.GetByIdAsync(id.Value);
            if (company == null)
            {
                return NotFound();
            }

            var companyViewModel = new CompanyViewModel
            {
                CompanyID = company.CompanyID,
                Name = company.Name,
                Location = company.Location,
                Description = company.Description,
                Logo = company.Logo,
                PartnershipID = company.PartnershipID,
                Partnerships = new PartnershipViewModel  
                {
                    PartnershipID = company.Partnerships.PartnershipID,  
                TypeShipp = company.Partnerships.TypeShipp,
                Logo=company.Partnerships.Logo,
                Description=company.Partnerships.Description,
                }
            };

            return View(companyViewModel);
        }

        // GET: Administrator/Companies/Create
        [Route("/Companies/Create")]
        public IActionResult Create()
        {
            var partnership = _partnershipRepository.GetAllAsync().Result;
            ViewBag.PartnerShip = new SelectList(partnership, "PartnershipID", "TypeShipp");
            return View();
        }

        // POST: Administrator/Companies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Companies/Create")]
        public async Task<IActionResult> Create(CompanyViewModel companyViewModel)
        {
        
            if (ModelState.IsValid)
            {
                var company = new Company
                {
                    Name = companyViewModel.Name,
                    Location = companyViewModel.Location,
                    Description = companyViewModel.Description,
                    Logo = companyViewModel.Logo,
                    PartnershipID = companyViewModel.PartnershipID,
                    CreatedBy = User.Identity.Name, 
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    IsActive = true,
                    IsDelete = false
                    
                };
                await _companyRepository.AddAsync(company);
                return RedirectToAction(nameof(Index));
            }
            var partnership = _partnershipRepository.GetAllAsync().Result;
            ViewBag.PartnerShip = new SelectList(partnership, "PartnershipID", "TypeShipp");
            return View(companyViewModel);
        }

        // GET: Administrator/Companies/Edit/5
        [Route("/Companies/Edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            var company = await _companyRepository.GetByIdAsync(id.Value);
            if (company == null)
            {
                return NotFound();
            }

            var companyViewModel = new CompanyViewModel
            {
                CompanyID = company.CompanyID,
                Name = company.Name,
                Location = company.Location,
                Description = company.Description,
                Logo = company.Logo,
                PartnershipID = company.PartnershipID,
                Partnerships = new PartnershipViewModel  
                {
                    PartnershipID = company.Partnerships.PartnershipID,  
                    TypeShipp = company.Partnerships.TypeShipp,
                }
            };
            var partnership = _partnershipRepository.GetAllAsync().Result;
            ViewBag.PartnerShip = new SelectList(partnership, "PartnershipID", "TypeShipp");

            return View(companyViewModel);
        }

        // POST: Administrator/Companies/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("/Companies/Edit/{id}")]
        public async Task<IActionResult> Edit(int id, CompanyViewModel companyViewModel)
        {
            if (id != companyViewModel.CompanyID)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                var partnerships = _partnershipRepository.GetAllAsync().Result;
                ViewBag.PartnerShip = new SelectList(partnerships, "PartnershipID", "TypeShipp");

                return View(companyViewModel);
            }


            var companyToUpdate = await _companyRepository.GetByIdAsync(id);
            if (companyToUpdate == null)
            {
                return NotFound();
            }

            companyToUpdate.Name = companyViewModel.Name;
            companyToUpdate.Location = companyViewModel.Location;
            companyToUpdate.Description = companyViewModel.Description;
            companyToUpdate.Logo=companyViewModel.Logo;
            companyToUpdate.PartnershipID = companyViewModel.PartnershipID;
            companyToUpdate.ModifiedBy = User.Identity.Name;
            companyToUpdate.ModifiedOn = DateTime.Now;
            companyToUpdate.IsActive = companyViewModel.IsActive;
            companyToUpdate.IsDelete = companyViewModel.IsDelete;


            try
            {
                await _companyRepository.UpdateAsync(companyToUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ModelState.AddModelError("", "A concurrency error occurred. Someone else might have updated the data. Please try again.");
            }
            catch (DbUpdateException ex)
            {
                ModelState.AddModelError("", "An error occurred while updating the data. Please review the data and try again.");
            }

            var partnership = _partnershipRepository.GetAllAsync().Result;
            ViewBag.PartnerShip = new SelectList(partnership, "PartnershipID", "TypeShipp");

            return View(companyViewModel);
        }



        [Route("/Companies/Delete/{id}")]
        // GET: Administrator/Cars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var company = await _companyRepository.GetByIdAsync(id.Value);
            if (company == null)
            {
                return NotFound();
            }

            var companyViewModel = new CompanyViewModel
            {
                CompanyID = company.CompanyID,
                Name = company.Name,
                Location = company.Location,
                Description = company.Description,
                Logo = company.Logo,
                PartnershipID = company.PartnershipID,
                Partnerships = new PartnershipViewModel  
                {
                    PartnershipID = company.Partnerships.PartnershipID,  
                    TypeShipp = company.Partnerships.TypeShipp,
                }
            };
            var partnership = _partnershipRepository.GetAllAsync().Result;
            ViewBag.PartnerShip = new SelectList(partnership, "PartnershipID", "TypeShipp");


            return View(companyViewModel);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        // POST: Administrator/Cars/Delete/5
        [Route("/Companies/Delete/{id}")]

        public IActionResult DeleteConfirmed(int id)
        {
            var company = _companyRepository.GetByIdAsync(id).Result;
            if (company != null)
            {
                _companyRepository.DeleteAsync(company).Wait();
            }

            return RedirectToAction(nameof(Index));
        }
    }
    }
