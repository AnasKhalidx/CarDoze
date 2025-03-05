using CarDoze.Models;
using CarDoze.Models.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDoze.Models.Repository
{
    public class ReviewRepository : IRepository<Review>
    {
        private readonly CarDozeDbContext _dbContext;

        public ReviewRepository(CarDozeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Review entity)
        {
            _dbContext.Reviews.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Review entity)
        {
            _dbContext.Reviews.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Review>> GetAllAsync()
        {
            return await _dbContext.Reviews.ToListAsync();
        }

        public async Task<Review> GetByIdAsync(int id)
        {
            return await _dbContext.Reviews.FindAsync(id);
        }

        public async Task UpdateAsync(Review entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<Review>> GetAllInactiveAsync()
        {
            return await _dbContext.Reviews.Where(r => !r.IsActive).ToListAsync();
        }
        public async Task<IEnumerable<Review>> GetAllActiveAsync()
        {
            return await _dbContext.Reviews.Where(r => r.IsActive && !r.IsDelete).ToListAsync();
        }

    

        public Task<IQueryable<Car>> GetAllQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetCompaniesByPartnershipIdAsync(int partnershipId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetFeatureNameByIdAsync(int featureId)
        {
            throw new NotImplementedException();
        }

		public Task<IEnumerable<Car>> GetAllCarsWithDetailsAsync()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Car>> GetLatestCarsAsync()
		{
			throw new NotImplementedException();
		}

        public Task<IEnumerable<CarCarFeature>> GetByCarIdAsync(int carId)
        {
            throw new NotImplementedException();
        }

        public Task<CarCarFeature> FindByCarIdAndFeatureId(int carId, int featureId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarModels>> GetByManufacturerIdAsync(int manufacturerId)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<CarModels> entities)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetRandomCars(int count)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<CarCarFeature> entities)
        {
            throw new NotImplementedException();
        }

        public Task<List<Wishlist>> GetWishlistsByUserAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Wishlist>> GetAllByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllWithDetailsAsync()
        {
            throw new NotImplementedException();
        }

    }
}
