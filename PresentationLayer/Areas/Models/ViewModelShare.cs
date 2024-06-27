using BusinessLogicLayer.Viewmodels.Address;
using BusinessLogicLayer.Viewmodels.ApplicationUser;
using BusinessLogicLayer.Viewmodels.ProductDetails;

namespace PresentationLayer.Areas.Models
{
    public class ViewModelShare
    {
        public AddressCreateVM Address { get; set; } 
        public RegisterUser RegisterUser { get; set; }

        public UserDataVM UserData { get; set; }
        public ProductDetailsCreateVM ProductDetailsCreateVM { get; set; }
    }
}
