using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarDoze.Models.Repository
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task<IQueryable<Car>> GetAllQueryable();
        Task<IEnumerable<Company>> GetCompaniesByPartnershipIdAsync(int partnershipId);
        Task<IEnumerable<Car>> GetAllCarsWithDetailsAsync();
        Task<IEnumerable<Car>> GetLatestCarsAsync();
        Task<string> GetFeatureNameByIdAsync(int featureId);
        Task<IEnumerable<CarCarFeature>> GetByCarIdAsync(int carId);
        Task<CarCarFeature> FindByCarIdAndFeatureId(int carId, int featureId);
        Task<IEnumerable<Review>> GetAllInactiveAsync();
        Task<IEnumerable<Review>> GetAllActiveAsync();
        Task<IEnumerable<CarModels>> GetByManufacturerIdAsync(int manufacturerId);
        Task AddRangeAsync(IEnumerable<CarModels> entities);
        List<Car> GetRandomCars(int count);
        Task AddRangeAsync(IEnumerable<CarCarFeature> entities);
        Task<IEnumerable<Wishlist>> GetAllByUserIdAsync(string userId);
        Task<IEnumerable<Order>> GetAllWithDetailsAsync();
    }
        

    public interface ICarRepository : IRepository<Car>
    {
        Task<IEnumerable<Car>> GetCarsByManufacturerIdAsync(int manufacturerId);
        Task<IEnumerable<Car>> GetCarsByFuelTypeAsync(string fuelType);
        Task<IEnumerable<Review>> GetReviewsByCarIdAsync(int carId);
       


    }

    public interface IUserRepository
    {
        Task<IdentityUser> GetUserByEmailAsync(string email);
        Task<IEnumerable<Notification>> GetNotificationsByUserIdAsync(string userId);
        Task<IEnumerable<Wishlist>> GetWishlistsByUserIdAsync(string userId);
    }

    public interface IPartnershipRepository
    {
        Task<IEnumerable<Partnership>> GetPartnershipsByTypeAsync(string type);
    }

}
