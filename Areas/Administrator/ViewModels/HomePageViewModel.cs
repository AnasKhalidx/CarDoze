namespace CarDoze.Areas.Administrator.ViewModels
{
	public class HomePageViewModel
	{
		public IEnumerable<Models.Car> Cars { get; set; }
		public IEnumerable<CarDoze.Models.Review> Reviews { get; set; }
        public int ManufacturerID { get; set; }
        public int ModelID { get; set; }
    }

}
