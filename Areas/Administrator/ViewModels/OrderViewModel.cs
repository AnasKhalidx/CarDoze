using System;
using System.Collections.Generic;
using CarDoze.Models;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class OrderViewModel : BaseEntity
    {
        public int OrderID { get; set; }
        public int CarID { get; set; }
        public DateTime OrderDate { get; set; }
        public string? Status { get; set; }
        public int ShippingAddressID { get; set; }
        public string? PaymentMethodID { get; set; }
        public decimal TotalPrice { get; set; }
        public Car? Car { get; set; }
        public ShippingAddressViewModel ShippingAddress { get; set; }
        public PaymentMethod PaymentMethod { get; set; }

        public int? SelectedPartnershipID { get; set; }
        public int? SelectedCompanyID { get; set; }

        public int? SelectedPartnership2ID { get; set; }
        public int? SelectedCompany2ID { get; set; }

        public int? SelectedPartnership3ID { get; set; }
        public int? SelectedCompany3ID { get; set; }

        public List<PartnershipViewModel> Partnerships { get; set; } = new List<PartnershipViewModel>();
        public List<CompanyViewModel> Companies { get; set; } = new List<CompanyViewModel>();
    }
}
