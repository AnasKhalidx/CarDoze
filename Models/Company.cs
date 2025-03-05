using System.ComponentModel.DataAnnotations.Schema;

namespace CarDoze.Models
{
    public class Company :BaseEntity
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
     
        public Partnership Partnerships { get; set; }
        public int PartnershipID { get; set; }
    }
}
