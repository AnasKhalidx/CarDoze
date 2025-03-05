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
    public class PartnershipRepository : IRepository<Partnership>
    {
        private readonly CarDozeDbContext _dbContext;

        public PartnershipRepository(CarDozeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Partnership entity)
        {
            _dbContext.Partnerships.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Partnership entity)
        {
            _dbContext.Partnerships.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Partnership>> GetAllAsync()
        {
            return await _dbContext.Partnerships.ToListAsync();
        }

        public async Task<Partnership> GetByIdAsync(int id)
        {
            return await _dbContext.Partnerships.FindAsync(id);
        }

        public async Task UpdateAsync(Partnership entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Partnership>> GetPartnershipsByTypeAsync(string type)
        {
            return await _dbContext.Partnerships
                .Where(partnership => partnership.TypeShipp == type)
                .ToListAsync();
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

        public Task<IEnumerable<Review>> GetAllInactiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAllActiveAsync()
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
