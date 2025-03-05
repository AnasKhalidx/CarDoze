using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarDoze.Models.Repository
{
    public class ShippingAddressRepository : IRepository<ShippingAddress>
    {
        private readonly CarDozeDbContext _dbContext;

        public ShippingAddressRepository(CarDozeDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task AddAsync(ShippingAddress entity)
        {
            try
            {
                entity.CreatedOn = DateTime.Now;
                _dbContext.ShippingAddresses.Add(entity);
                await _dbContext.SaveChangesAsync();
            }
            catch (Exception ex)
            {
            }

        }

        public async Task DeleteAsync(ShippingAddress entity)
        {
            _dbContext.ShippingAddresses.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<ShippingAddress>> GetAllAsync()
        {
            return await _dbContext.ShippingAddresses.ToListAsync();
        }

        public async Task<ShippingAddress> GetByIdAsync(int id)
        {
            return await _dbContext.ShippingAddresses.FindAsync(id);
        }


        public async Task UpdateAsync(ShippingAddress entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public bool Exists(int orderID)
        {
            return _dbContext.Orders.Any(o => o.OrderID == orderID);
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
