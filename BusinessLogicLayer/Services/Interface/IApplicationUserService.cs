using BusinessLogicLayer.Viewmodels;
using BusinessLogicLayer.Viewmodels.ApplicationUser;
using DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLayer.Entity.Base.EnumBase;

namespace BusinessLogicLayer.Services.Interface
{
    public interface IApplicationUserService
    {
        Task<List<UserDataVM>> GetAllInformationAsync();
        Task<List<UserDataVM>> GetAllActiveInformationAsync();
        Task<UserDataVM> GetInformationByID(string ID);
        Task<bool> RemoveAsync(string ID, string IDUserDelete);
        Task<Response> RegisterAsync(RegisterUser registerUser, string role);
        public Task<Response> Login(UserLoginModel model);
        Task<List<Address>> GetAddressesByTypeAsync(AdressType type);

    }
}
