using BusinessLogicLayer.Viewmodels.Brand;
using BusinessLogicLayer.Viewmodels.Manufacturer;
using BusinessLogicLayer.Viewmodels.Material;
using BusinessLogicLayer.Viewmodels.Product;
using BusinessLogicLayer.Viewmodels.ProductDetails;

namespace PresentationLayer.Areas.Admin.Models
{
    public class CompositeViewModel
    {
        public ProductVM ProductVM { get; set; }
        public ManufacturerVM ManufacturerVM { get; set; }
        public MaterialVM MaterialVM { get; set; }
        public BrandVM BrandVM { get; set; }

        public ProductDetailsCreateVM ProductDetailsCreateVM { get; set; }
    }
}
