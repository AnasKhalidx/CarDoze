using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using CarDoze.ViewModels;

namespace CarDoze.Models
{
    public class Car :BaseEntity
    {
        public int CarID { get; set; }

        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string FuelType { get; set; }
        public List<string> ImageURLs { get; set; } = new List<string>(); 
        public string Description { get; set; }

        public ICollection<CarCarFeature> CarFeatures { get; set; }
        public List<CarModels>? Models { get; set; } = new List<CarModels>();

        public ICollection<Wishlist>? Wishlists { get; set; }
        public ICollection<CompareCar> ?CompareCars { get; set; }
        public ICollection<Review> ?Reviews { get; set; }
        public int ModelID { get;  set; }
    }

    public class CarFeature:BaseEntity
    {
        public int CarFeatureID { get; set; }
        public string FeatureName { get; set; }
        public ICollection<CarCarFeature> CarCarFeatures { get; set; }


    }
    public class CarCarFeature
    {
        public int FeatureID { get; set; }
        public int CarID { get; set; }
        public string FeatureName { get; set; } 
        public Car Car { get; set; } 
        public CarFeature CarFeature { get; set; } 
    }
}
