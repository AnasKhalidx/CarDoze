using CarDoze.Models;

namespace CarDoze.ViewModels
{
    public class CarModelViewModel :BaseEntity
    {
        public int ModelsID { get; set; }
        public string ModelName { get; set; }
        public int ManufacturerID { get; set; }
    }
}
