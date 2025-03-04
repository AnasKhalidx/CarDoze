using CarDoze.Models;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class ReviewViewModel : BaseEntity
    {
        public int ReviewID { get; set; }
     
        public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
