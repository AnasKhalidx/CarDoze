using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarDoze.Models.Repository
{
    public class CarModelRepository : IRepository<CarModels>
    {
        private readonly CarDozeDbContext _context;

        public CarModelRepository(CarDozeDbContext context)
        {
            _context = context;
        }

        public async Task<CarModels> GetByIdAsync(int id)
        {
            return await _context.Set<CarModels>().FindAsync(id);
        }

        public async Task<IEnumerable<CarModels>> GetAllAsync()
        {
            return await _context.Set<CarModels>().ToListAsync();
        }

        public async Task AddAsync(CarModels entity)
        {
            await _context.Set<CarModels>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CarModels entity)
        {
            _context.Set<CarModels>().Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(CarModels entity)
        {
            _context.Set<CarModels>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async Task<IEnumerable<CarModels>> GetByManufacturerIdAsync(int manufacturerId)
        {
            return await _context.Set<CarModels>()
                .Where(m => m.ManufacturerID == manufacturerId)
                .ToListAsync();
        }
        public async Task AddRangeAsync(IEnumerable<CarModels> entities)
        {
            await _context.Set<CarModels>().AddRangeAsync(entities);
            await _context.SaveChangesAsync();
        }
        public Task<IQueryable<Car>> GetAllQueryable()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Company>> GetCompaniesByPartnershipIdAsync(int partnershipId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetAllCarsWithDetailsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Car>> GetLatestCarsAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<string> GetFeatureNameByIdAsync(int featureId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<CarCarFeature>> GetByCarIdAsync(int carId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CarCarFeature> FindByCarIdAndFeatureId(int carId, int featureId)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAllInactiveAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetAllActiveAsync()
        {
            throw new System.NotImplementedException();
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

