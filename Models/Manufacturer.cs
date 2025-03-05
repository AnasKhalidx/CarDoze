using System.ComponentModel.DataAnnotations.Schema;

namespace CarDoze.Models
{
    public class Manufacturer :BaseEntity
    {
        public int ManufacturerID { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
       
        public ICollection<Car>? ListedCars { get; set; }
        public ICollection<CarModels> Models { get; set; }
    }
}
