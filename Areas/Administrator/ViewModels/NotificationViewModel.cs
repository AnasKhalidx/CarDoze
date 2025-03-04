using CarDoze.Models;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class NotificationViewModel : BaseEntity
    {
        public int NotificationID { get; set; }
        public int UserID { get; set; }
        public int CarID { get; set; }
        public string Message { get; set; }
        public DateTime Timestamp { get; set; }
        public NotificationStatus Status { get; set; }
    }
}
