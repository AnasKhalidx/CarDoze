using CarDoze.Models;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class CarFeatureViewModel : BaseEntity
    {
        public int CarFeatureID { get; set; }
        public string FeatureName { get; set; }
        public ICollection<CarCarFeatureViewModel> Cars { get; set; } = new List<CarCarFeatureViewModel>();

    }
}
