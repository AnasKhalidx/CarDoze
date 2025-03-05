using System.ComponentModel.DataAnnotations.Schema;

namespace CarDoze.Models
{
    public class CompareCar : BaseEntity
    {
        public int CompareID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
        public string ComparisonResult { get; set; }
    }

}

