using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Category;
using BusinessLogicLayer.Viewmodels.Material;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        public CategoryService(ApplicationDBContext ApplicationDBContext, IMapper mapper)
        {
            _dbcontext = ApplicationDBContext;
            _mapper = mapper;
        }
        public async Task<bool> CreateAsync(CategoryCreateVM request)
        {
            if (request != null)
            {
                var Obj = new Category()
                {
                    ID = Guid.NewGuid(),
                    Name = request.Name,
                    Description = request.Description,
                    Status = 1,
                    CreateBy = request.CreateBy,
                    CreateDate = DateTime.Now,

                };
                await _dbcontext.Category.AddRangeAsync(Obj);
                await _dbcontext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<CategoryVM>> GetAllActiveAsync()
        {
            var Obj = await _dbcontext.Category.Where(b => b.Status == 1).ToListAsync();
            return _mapper.Map<List<CategoryVM>>(Obj);
        }

        public async Task<List<CategoryVM>> GetAllAsync()
        {
            var Obj = await _dbcontext.Category.ToListAsync();
            return _mapper.Map<List<CategoryVM>>(Obj);
        }

        public async Task<CategoryVM> GetByIDAsync(Guid ID)
        {
            var Obj = await _dbcontext.Category.FindAsync(ID);
            return _mapper.Map<CategoryVM>(Obj);
        }

        public async Task<bool> RemoveAsync(Guid ID, string IDUserDelete)
        {

            using (var transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var obj = await _dbcontext.Category.FirstOrDefaultAsync(c => c.ID == ID);

                    if (obj != null)
                    {
                        obj.Status = 0;
                        obj.DeleteDate = DateTime.Now;
                        obj.DeleteBy = IDUserDelete;

                        _dbcontext.Category.Attach(obj);
                        await _dbcontext.SaveChangesAsync();


                        transaction.Commit();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return false;
                }
            }
        }

        public async Task<bool> UpdateAsync(Guid ID, CategoryUpdateVM request)
        {
            var Obj = await _dbcontext.Category.FindAsync(ID);
            if (Obj == null)
            {
                return false;
            }

            Obj.Name = request.Name;
            Obj.Description = request.Description;
            Obj.Status = request.Status;
            Obj.ModifiedBy = request.ModifiedBy;
            Obj.ModifiedDate = DateTime.Now;

            _dbcontext.Category.Update(Obj);
            await _dbcontext.SaveChangesAsync();
            return true;
        }
    }
}
