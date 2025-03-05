using CarDoze.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using CarDoze.Areas.Administrator.ViewModels;
using Microsoft.AspNetCore.Identity;

namespace CarDoze.Models.Repository
{
    public class CarFeatureRepository : IRepository<CarFeature>


    {
        private readonly CarDozeDbContext _context;

        public CarFeatureRepository(CarDozeDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(CarFeature entity)
        {
            try
            {
                _context.CarFeatures.Add(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An error occurred while saving the car feature.", ex);
            }
        }

        public async Task<IEnumerable<CarFeature>> GetAllAsync()
        {
            try
            {
                return await _context.CarFeatures
                    .Select(cf => new CarFeature
                    {
                        CarFeatureID = cf.CarFeatureID,
                        FeatureName = cf.FeatureName
                    })
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving car features.", ex);
            }
        }

        public async Task<CarFeature> GetByIdAsync(int id)
        {
            try
            {
                return await _context.CarFeatures.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving a car feature with ID {id}.", ex);
            }
        }

        public async Task UpdateAsync(CarFeature entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                throw new Exception("A concurrency error occurred while updating a car feature.", ex);
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An error occurred while updating the car feature.", ex);
            }
        }

        public async Task DeleteAsync(CarFeature entity)
        {
            try
            {
                _context.CarFeatures.Remove(entity);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
                throw new Exception("An error occurred while deleting the car feature.", ex);
            }
        }

        public IQueryable<CarFeature> GetAllQueryable()
        {
            return _context.CarFeatures.AsQueryable();
        }
        public async Task<string> GetFeatureNameByIdAsync(int featureId)
        {
            try
            {
                var feature = await _context.CarFeatures.FindAsync(featureId);
                return feature != null ? feature.FeatureName : null;
            }
            catch (Exception ex)
            {
                throw new Exception($"An error occurred while retrieving the feature name for feature ID {featureId}.", ex);
            }
        }

		Task<IQueryable<Car>> IRepository<CarFeature>.GetAllQueryable()
		{
			throw new NotImplementedException();
		}

		public Task<IEnumerable<Company>> GetCompaniesByPartnershipIdAsync(int partnershipId)
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
