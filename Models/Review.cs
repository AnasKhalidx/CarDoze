namespace CarDoze.Models
{
    public class Review : BaseEntity
    {
        public int ReviewID { get; set; }
     public int Rating { get; set; }
        public string Comment { get; set; }
    }
}
