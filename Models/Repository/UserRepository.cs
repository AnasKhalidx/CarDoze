/*using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CarDoze.Models.Repository
{
    public class UserRepository : IRepository<IdentityUser>
    {
        private readonly CarDozeDbContext dbContext;

        public UserRepository(CarDozeDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Add(IdentityUser entity)
        {
            dbContext.Users.Add(entity);
            dbContext.SaveChanges();
        }

        public void Delete(IdentityUser entity)
        {
            dbContext.Users.Remove(entity);
            dbContext.SaveChanges();
        }

        public IEnumerable<IdentityUser> GetAll()
        {
            return dbContext.Users.ToList();
        }

        public IdentityUser GetById(int id)
        {
            return dbContext.Users.Find(id);
        }

        public void Update(IdentityUser entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        // Custom method to get a user by email
        public IdentityUser GetUserByEmail(string email)
        {
            return dbContext.Users
                .FirstOrDefault(user => user.Email == email);
        }

        public IEnumerable<IdentityUser> GetCompaniesByPartnershipId(int partnershipId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetCarsByManufacturerId(int manufacturerId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetCarsByFuelType(string fuelType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Manufacturer> GetManufacturersByAdminId(int adminId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notification> GetNotificationsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Partnership> GetPartnershipsByType(string type)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Review> GetReviewsByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Wishlist> GetWishlistsByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        // Additional custom methods as needed...

    }
}
*/