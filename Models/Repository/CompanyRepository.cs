using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarDoze.Models.Repository
{
    public class CompanyRepository : IRepository<Company>
    {
        private readonly CarDozeDbContext _dbContext;

        public CompanyRepository(CarDozeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Company entity)
        {
            _dbContext.Companies.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Company entity)
        {
            _dbContext.Companies.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _dbContext.Companies.Include(x=>x.Partnerships).ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await _dbContext.Companies.Include(x=>x.Partnerships).FirstOrDefaultAsync(c => c.CompanyID == id);
        }

        public async Task UpdateAsync(Company entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Company>> GetCompaniesByPartnershipIdAsync(int partnershipId)
        {
            return await _dbContext.Companies
                .Where(company => company.PartnershipID == partnershipId)
                .ToListAsync();
        }

     

        public Task<string> GetFeatureNameByIdAsync(int featureId)
        {
            throw new NotImplementedException();
        }

        Task<IQueryable<Car>> IRepository<Company>.GetAllQueryable()
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
