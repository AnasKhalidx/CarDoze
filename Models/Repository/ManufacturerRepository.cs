using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarDoze.Models.Repository
{
    public class ManufacturerRepository : IRepository<Manufacturer>
    {
        private readonly CarDozeDbContext _dbContext;

        public ManufacturerRepository(CarDozeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Manufacturer entity)
        {
            _dbContext.Manufacturers.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task AddRangeAsync(IEnumerable<CarModels> entities)
        {
            throw new NotImplementedException();
        }

        public Task AddRangeAsync(IEnumerable<CarCarFeature> entities)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(Manufacturer entity)
        {
            _dbContext.Manufacturers.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task<CarCarFeature> FindByCarIdAndFeatureId(int carId, int featureId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAllActiveAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Manufacturer>> GetAllAsync()
        {
            return await _dbContext.Manufacturers.ToListAsync();
        }

        public Task<IEnumerable<Wishlist>> GetAllByUserIdAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllCarsWithDetailsAsync()
		{
			throw new NotImplementedException();
		}

        public Task<IEnumerable<Review>> GetAllInactiveAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Car>> GetAllQueryable()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllWithDetailsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CarCarFeature>> GetByCarIdAsync(int carId)
        {
            throw new NotImplementedException();
        }

        public async Task<Manufacturer> GetByIdAsync(int id)
        {
            return await _dbContext.Manufacturers.FindAsync(id);
        }

        public Task<IEnumerable<CarModels>> GetByManufacturerIdAsync(int manufacturerId)
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

		public Task<IEnumerable<Car>> GetLatestCarsAsync()
		{
			throw new NotImplementedException();
		}

        public List<Car> GetRandomCars(int count)
        {
            throw new NotImplementedException();
        }

        public Task<List<Wishlist>> GetWishlistsByUserAsync(IdentityUser user)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Manufacturer entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

     
    }
}
