using CarDoze.Models;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class PartnershipViewModel : BaseEntity
    {
        public int PartnershipID { get; set; }
        public string TypeShipp { get; set; }
        public string Logo { get; set; }
        public string Description { get; set; }
        public ICollection<CompanyViewModel> ?Companys { get; set; }
        public ICollection<OrderViewModel>? Orders { get; set; }
    }
}
