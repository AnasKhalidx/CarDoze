using CarDoze.Models;
using CarDoze.Models.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarDoze.Areas.Administrator.Controllers
{
    [Area("Administrator")]
    [Authorize(Roles = "Admin")]
    public class ReviewsController : Controller
    {
        private readonly IRepository<Review> _reviewRepository;

        public ReviewsController(IRepository<Review> reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        [HttpGet]
        [Route("Review/Approve/{id}")]
        public async Task<IActionResult> ApproveReview(int id)
        {
            var review = await _reviewRepository.GetByIdAsync(id);
            if (review != null && !review.IsActive)
            {
                review.IsActive = true;
                await _reviewRepository.UpdateAsync(review);
                TempData["Message"] = "Review has been approved.";
            }
            else if (review == null)
            {
                TempData["Error"] = "Review not found.";
            }
            else
            {
                TempData["Message"] = "Review is already active.";
            }

            return RedirectToAction("ReviewList");
        }

        [HttpGet]
        [Route("Review/List")]
        public async Task<IActionResult> ReviewList()
        {
            var reviews = await _reviewRepository.GetAllInactiveAsync();
            return View(reviews);
        }
        [HttpGet]
        [Route("Review/All")]
        public async Task<IActionResult> AllReviewList()
        {
            var allReviews = await _reviewRepository.GetAllAsync();

            var filteredReviews = allReviews.Where(review => review.IsDelete || review.IsActive);

            return View(filteredReviews);
        }


        [HttpGet]
        [Route("Review/Delete/{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            var review = await _reviewRepository.GetByIdAsync(id);
            if (review != null)
            {
                review.IsDelete = true;
                await _reviewRepository.UpdateAsync(review);
                TempData["Message"] = "Review has been deleted.";
            }
            else
            {
                TempData["Error"] = "Review not found.";
            }

            return RedirectToAction("ReviewList");
        }
    }

}
