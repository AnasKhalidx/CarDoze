

using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace CarDoze.Models
{
    public class Order : BaseEntity
    {
        public int OrderID { get; set; }
        public int CarID { get; set; }

        public DateTime OrderDate { get; set; }
        public string? Status { get; set; }
        public int ShippingAddressID { get; set; }
        public decimal TotalPrice { get; set; }

        public Car Car { get; set; }

        public ShippingAddress ShippingAddress { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
    }

    public class ShippingAddress : BaseEntity
    {
        public int ShippingAddressID { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipCode { get; set; }
    }
    public enum PaymentMethod
    {
        CreditCard,
        DebitCard,
        PayPal,
    }
}