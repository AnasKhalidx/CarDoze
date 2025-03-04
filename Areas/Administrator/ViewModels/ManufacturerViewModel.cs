using System.Collections.Generic;
using CarDoze.Models;
using CarDoze.ViewModels;

namespace CarDoze.Areas.Administrator.ViewModels
{
    public class ManufacturerViewModel : BaseEntity
    {
        public int ManufacturerID { get; set; }
        public string? Name { get; set; }
        public string? Logo { get; set; }
        public string? Description { get; set; }
        public ICollection<CarViewModel>? ListedCars { get; set; }
        public List<CarModelViewModel> CarModels { get; set; }

        public ManufacturerViewModel()
        {
            CarModels = new List<CarModelViewModel>();
        }
    }
}
