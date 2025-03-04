namespace CarDoze.Areas.Administrator.ViewModels
{
    public class CarCarFeatureViewModel
    {
        public CarViewModel CarViewModel { get; set; }
        public int CarID { get; set; }
        public CarFeatureViewModel CarFeatureViewModel  { get; set; }
        public int FeatureID { get; set; }
        public string FeatureName { get; set; } 


    }
}
