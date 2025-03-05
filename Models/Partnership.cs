namespace CarDoze.Models
{
    public class Partnership : BaseEntity
    {
        public int PartnershipID { get; set; }
    
        public string TypeShipp { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public ICollection<Company> Companys { get; set; }  
        public ICollection<Order> Orders { get; set; }
    }
  
}
