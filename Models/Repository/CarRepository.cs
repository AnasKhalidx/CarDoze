using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarDoze.Models.Repository
{
    public class CarRepository : IRepository<Car>
    {
        private readonly CarDozeDbContext _dbContext;

        public CarRepository(CarDozeDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Car entity)
        {
            _dbContext.Cars.Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Car>> GetAllAsync()
        {
            return await _dbContext.Cars.Include(x=>x.Manufacturer)
                                        .Include(c => c.CarFeatures)
                                            .ThenInclude(cf => cf.CarFeature) 
                                        .ToListAsync();
        }

        public async Task DeleteAsync(Car entity)
        {
            _dbContext.Cars.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Car> GetByIdAsync(int id)
        {
            return await _dbContext.Cars
                .Include(c => c.Manufacturer)
                .Include(c => c.CarFeatures)
                    .ThenInclude(cf => cf.CarFeature)
                .Include(c => c.Models)
                .FirstOrDefaultAsync(c => c.CarID == id);
        }



        public async Task UpdateAsync(Car entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Car>> GetCarsByManufacturerIdAsync(int manufacturerId)
        {
            return await _dbContext.Cars
                .Where(car => car.ManufacturerID == manufacturerId)
                .ToListAsync();
        }

        public async Task<IEnumerable<Car>> GetCarsByFuelTypeAsync(string fuelType)
        {
            return await _dbContext.Cars
                .Where(car => car.FuelType == fuelType)
                .ToListAsync();
        }

    
        public async Task<IQueryable<Car>> GetAllQueryable()
        {
            var cars = await _dbContext.Cars.ToListAsync();

            return cars.AsQueryable().Include(c => c.Manufacturer).Include(c => c.CarFeatures);
        }
		public async Task<IEnumerable<Car>> GetAllCarsWithDetailsAsync()
		{
			return await _dbContext.Cars
				.Include(c => c.Manufacturer)
				.ToListAsync();
		}
		public async Task<IEnumerable<Car>> GetLatestCarsAsync()
		{
			try
			{
				var cars = await _dbContext.Cars
					.Include(c => c.Manufacturer)
					.Include(c => c.CarFeatures)
					.OrderByDescending(c => c.CreatedOn)
					.Take(5)
					.ToListAsync();

				Console.WriteLine($"Fetched {cars.Count} cars"); 
				return cars;
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error fetching latest cars: {ex.Message}");
				return new List<Car>();
			}
		}
        public List<Car> GetRandomCars(int count)
        {
            return _dbContext.Cars.OrderBy(r => Guid.NewGuid()).Take(count).ToList();
        }


        public Task<IEnumerable<Company>> GetCompaniesByPartnershipIdAsync(int partnershipId)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetFeatureNameByIdAsync(int featureId)
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
