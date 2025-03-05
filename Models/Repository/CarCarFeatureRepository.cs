using CarDoze.Models.Repository;
using CarDoze.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CarDoze.Models.Repository
{
    public class CarCarFeatureRepository
    {
    }
}
public class CarCarFeatureRepository : IRepository<CarCarFeature>
{
    private readonly CarDozeDbContext _context;

    public CarCarFeatureRepository(CarDozeDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(CarCarFeature entity)
    {
        _context.CarCarFeatures.Add(entity);
        await _context.SaveChangesAsync();
    }

    public Task AddRangeAsync(IEnumerable<CarModels> entities)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteAsync(CarCarFeature entity)
    {
        _context.CarCarFeatures.Remove(entity);
        await _context.SaveChangesAsync();
    }

    public async Task<CarCarFeature> FindByCarIdAndFeatureId(int carId, int featureId)
    {
        return await _context.CarCarFeatures
            .FirstOrDefaultAsync(f => f.CarID == carId && f.FeatureID == featureId);
    }
    public async Task AddRangeAsync(IEnumerable<CarCarFeature> entities)
    {
        foreach (var entity in entities)
        {
            var existingEntity = await _context.CarCarFeatures
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.CarID == entity.CarID && e.FeatureID == entity.FeatureID);

            if (existingEntity != null)
            {
                _context.Entry(existingEntity).State = EntityState.Detached;
            }

            _context.CarCarFeatures.Add(entity);
        }

        await _context.SaveChangesAsync();
    }
    public Task<IEnumerable<Review>> GetAllActiveAsync()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<CarCarFeature>> GetAllAsync()
    {
        return await _context.CarCarFeatures.ToListAsync();
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

    public async Task<IEnumerable<CarCarFeature>> GetByCarIdAsync(int carId)
    {
        return await _context.CarCarFeatures
            .Where(cf => cf.CarID == carId)
            .Include(cf => cf.CarFeature) 
            .ToListAsync();
    }


    public async Task<CarCarFeature> GetByIdAsync(int id)
    {
        return await _context.CarCarFeatures.FindAsync(id);
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

    public async Task UpdateAsync(CarCarFeature entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        await _context.SaveChangesAsync();
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
