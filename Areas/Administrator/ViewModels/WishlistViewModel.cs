using CarDoze.Models;
using System.Collections.Generic;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class WishlistViewModel : BaseEntity
    {
        public int WishlistID { get; set; }
        public int CarID { get; set; }
        public List<CarViewModel> Cars { get; set; } = new List<CarViewModel>(); // Property to hold car details
    }
}
