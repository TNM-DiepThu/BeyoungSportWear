using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Address;
using CloudinaryDotNet.Core;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;

namespace BusinessLogicLayer.Services.Implements
{
    public partial class AddressService : IAddressService
    {
        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        public AddressService(ApplicationDBContext ApplicationDBContext, IMapper mapper)
        {
            _dbcontext = ApplicationDBContext;
            _mapper = mapper;
        }
        public async Task<bool> CreateAsync(AddressCreateVM request)
        {
            if (request != null)
            {
                var Obj = new Address()
                {
                    ID = Guid.NewGuid(),
                    City = request.City,
                    IDUser = request.IDUser,
                    DistrictCounty = request.DistrictCounty,
                    Commune = request.Commune,
                    SpecificAddress = request.SpecificAddress,
                    Status = 1,
                    CreateBy = request.CreateBy,
                    CreateDate = DateTime.Now,

                };
                await _dbcontext.Address.AddRangeAsync(Obj);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<AddressVM>> GetAddressByIDUserAsync(string IDUser)
        {
            var addresses = await _dbcontext.Address.Where(a => a.IDUser == IDUser && a.Status == 1).ToListAsync();
            return _mapper.Map<List<AddressVM>>(addresses);
        }

        public async Task<List<AddressVM>> GetAllActiveAsync()
        {
            var addresses = await _dbcontext.Address.Where(a => a.Status == 1).ToListAsync();
            return _mapper.Map<List<AddressVM>>(addresses);
        }

        public async Task<List<AddressVM>> GetAllAsync()
        {
            var addresses = await _dbcontext.Address.ToListAsync();
            return _mapper.Map<List<AddressVM>>(addresses);
        }

        public async Task<AddressVM> GetByIDAsync(Guid ID)
        {
            var address = await _dbcontext.Address.FindAsync(ID);
            return _mapper.Map<AddressVM>(address);
        }

        public async Task<bool> RemoveAsync(Guid ID, string IDUserDelete)
        {
            var address = await _dbcontext.Address.FindAsync(ID);
            if (address != null)
            {
                address.Status = 0; 
                address.DeleteBy = IDUserDelete;
                address.DeleteDate = DateTime.Now;

                _dbcontext.Address.Update(address);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> UpdateAsync(Guid ID, AddressUpdateVM request)
        {
            var address = await _dbcontext.Address.FindAsync(ID);
            if (address != null)
            {
                address.City = request.City;
                address.Commune = request.Commune;
                address.DistrictCounty = request.DistrictCounty;
                address.SpecificAddress = request.SpecificAddress;
                address.ModifiedDate = DateTime.Now;
                address.ModifiedBy = request.ModifiedBy;

                _dbcontext.Address.Update(address);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
