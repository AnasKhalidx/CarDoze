using CarDoze.Models;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class CompareCarViewModel : BaseEntity
    {
        public int CompareID { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
    }
}
