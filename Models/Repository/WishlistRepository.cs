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
    public class WishlistRepository : IRepository<Wishlist>
    {
        private readonly CarDozeDbContext _dbContext;
        private readonly UserManager<IdentityUser> _userManager;

        public WishlistRepository(CarDozeDbContext dbContext, UserManager<IdentityUser> userManager)
        {
            _dbContext = dbContext;
            _userManager = userManager;
        }



        public async Task DeleteAsync(Wishlist entity)
        {
            _dbContext.Wishlists.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }


        public async Task<IEnumerable<Wishlist>> GetAllAsync()
        {
            return await _dbContext.Wishlists.ToListAsync();
        }



        public async Task UpdateAsync(Wishlist entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Wishlist>> GetAllByUserIdAsync(string userId)
        {
            return await _dbContext.Wishlists
                .Where(w => w.CreatedBy == userId)
                .Include(w => w.Car)
                    .ThenInclude(c => c.Manufacturer)
                .Include(w => w.Car)
                    .ThenInclude(c => c.CarFeatures)
                        .ThenInclude(cf => cf.CarFeature)
                .Include(w => w.Car)
                    .ThenInclude(c => c.Models)
                .ToListAsync();
        }

        public async Task<Wishlist> GetByIdAsync(int id)
        {
            return await _dbContext.Wishlists
                .Include(w => w.Car)
                    .ThenInclude(c => c.Manufacturer)
                .Include(w => w.Car)
                    .ThenInclude(c => c.CarFeatures)
                        .ThenInclude(cf => cf.CarFeature)
                .Include(w => w.Car)
                    .ThenInclude(c => c.Models)
                .FirstOrDefaultAsync(w => w.WishlistID == id);
        }

        public async Task AddAsync(Wishlist entity)
        {
            _dbContext.Wishlists.Add(entity);
            await _dbContext.SaveChangesAsync();
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

        public Task<IEnumerable<Order>> GetAllWithDetailsAsync()
        {
            throw new NotImplementedException();
        }

       
    }
}
