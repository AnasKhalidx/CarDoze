using Microsoft.AspNetCore.Identity;

namespace CarDoze.Models
{

    public class Wishlist : BaseEntity
    {
        public int WishlistID { get; set; }
        public int CarID { get; set; }
        public Car Car { get; set; }
    }

}
