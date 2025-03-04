using CarDoze.Models;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class ShippingAddressViewModel : BaseEntity
    {
        public int ShippingAddressID { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
}
