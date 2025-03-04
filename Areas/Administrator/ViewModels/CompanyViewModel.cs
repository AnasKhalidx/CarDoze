using CarDoze.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class CompanyViewModel : BaseEntity
    {

        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Logo { get; set; }
        public PartnershipViewModel? Partnerships { get; set; }
        public int PartnershipID { get; set; }
    }
}
