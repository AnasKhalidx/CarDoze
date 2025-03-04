using CarDoze.Models;
using CarDoze.ViewModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class CarViewModel : BaseEntity
    {
        public int CarID { get; set; }
        public string? Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string FuelType { get; set; }
        public List<string> ImageURLs { get; set; } = new List<string>();
        public string? Description { get; set; }
        public int ModelID { get; set; } 

        public ManufacturerViewModel? Manufacturer { get; set; }
        public ICollection<CarCarFeatureViewModel>? CarFeatures { get; set; } = new List<CarCarFeatureViewModel>();
        public ICollection<Wishlist>? Wishlists { get; set; }
        public ICollection<CompareCar>? CompareCars { get; set; }
        public ICollection<Review>? Reviews { get; set; }
        public List<CarModelViewModel>? Models { get; set; } = new List<CarModelViewModel>();

        public PaymentMethod? PaymentMethod { get; set; }
    }

    public enum PaymentMethod
    {
        CreditCard,
        DebitCard,
        PayPal
    }
}

