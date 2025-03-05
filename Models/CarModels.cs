using MessagePack;

namespace CarDoze.Models
{
    public class CarModels:BaseEntity
    {
        public int ModelsID { get; set; }
        public string ModelName { get; set; }
        public int ManufacturerID { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
