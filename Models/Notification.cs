using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace CarDoze.Models
{
    public class Notification : BaseEntity
    {
        public int NotificationID { get; set; }

        public string UserId { get; set; } 

        public IdentityUser User { get; set; } 

        public int CarID { get; set; }

        public Car Car { get; set; }

        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public NotificationStatus Status { get; set; }
    }

    public enum NotificationStatus
    {
        Unread,
        Read
    }
}
