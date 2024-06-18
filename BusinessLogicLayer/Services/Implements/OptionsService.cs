using AutoMapper;
using AutoMapper.QueryableExtensions;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Options;
using CloudinaryDotNet.Actions;
using CloudinaryDotNet;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implements
{
    public class OptionsService : IOptionsService
    {
        private readonly Cloudinary _cloudinary;

        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        public OptionsService(ApplicationDBContext ApplicationDBContext, IMapper mapper, Cloudinary Cloudinary)
        {
            _dbcontext = ApplicationDBContext;
            _cloudinary = Cloudinary;
            _mapper = mapper;
        }
        public async Task<Guid> EnsureSize(string sizeName, string CreateBy)
        {
            var size = await _dbcontext.Sizes
                .FirstOrDefaultAsync(s => s.Name.ToLower() == sizeName.ToLower());

            if (size == null)
            {
                size = new Sizes { ID = Guid.NewGuid(), Name = sizeName, CreateBy = CreateBy, Status = 1 };
                await _dbcontext.Sizes.AddAsync(size);
                await _dbcontext.SaveChangesAsync();
            }

            return size.ID;
        }
        public async Task<Guid> EnsureColor(string colorName, string CreateBy)
        {
            var color = await _dbcontext.Colors
                .FirstOrDefaultAsync(c => c.Name.ToLower() == colorName.ToLower());

            if (color == null)
            {
                color = new Colors { ID = Guid.NewGuid(), Name = colorName, CreateBy = CreateBy, Status = 1 };
                await _dbcontext.Colors.AddAsync(color);
                await _dbcontext.SaveChangesAsync();
            }

            return color.ID;
        }
        public async Task<bool> CreateAsync(OptionsCreateVM request)
        {
            var checkvariant = await _dbcontext.ProductDetails.FirstOrDefaultAsync(c => c.ID == request.IDProductDetails);
            var checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == request.IDColor);
            var checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == request.IDSize);

            if (checkvariant == null)
            {
                return false;
            }
            if (checkSizes == null && !string.IsNullOrEmpty(request.SizesName))
            {
                request.IDSize = await EnsureSize(request.SizesName, request.CreateBy);
            }

            if (checkColor == null && !string.IsNullOrEmpty(request.ColorName))
            {
                request.IDColor = await EnsureColor(request.ColorName, request.CreateBy);
            }
            checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == request.IDColor);
            checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == request.IDSize);
            var option = new Options
            {
                ID = Guid.NewGuid(),
                IDProductDetails = checkvariant.ID,
                IDColor = checkColor.ID,
                IDSize = checkSizes.ID,
                StockQuantity = request.StockQuantity,
                RetailPrice = request.RetailPrice,
                CostPrice = request.CostPrice,
                Discount = request.Discount,
                Status = 1,
                CreateBy = request.CreateBy,
            };
            _dbcontext.Options.Add(option);

            return true;
        }

        public Task<OptionsVM> FindIDOptionsAsync(Guid IDProductDetails, string size, string color)
        {
            throw new NotImplementedException();
        }

        public async Task<List<OptionsVM>> GetAllActiveAsync()
        {
            var objList = await _dbcontext.Options
                           .AsNoTracking()
                           .Where(b => b.Status != 0)
                           .ProjectTo<OptionsVM>(_mapper.ConfigurationProvider)
                           .ToListAsync();

            return objList ?? new List<OptionsVM>();
        }

        public async Task<List<OptionsVM>> GetAllAsync()
        {
            var objList = await _dbcontext.Options
                             .AsNoTracking()
                             .ProjectTo<OptionsVM>(_mapper.ConfigurationProvider)
                             .ToListAsync();

            return objList ?? new List<OptionsVM>();
        }

        public async Task<OptionsVM> GetByIDAsync(Guid ID)
        {
            var obj = await _dbcontext.Options
                           .Where(o => o.ID == ID)
                           .ProjectTo<OptionsVM>(_mapper.ConfigurationProvider)
                           .FirstOrDefaultAsync();

            return obj;
        }

        public Task<Guid> GetProductDetailsByID(Guid IDOptions)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> RemoveAsync(Guid ID, string IDUserdelete)
        {
            using (var transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var obj = await _dbcontext.Options.FirstOrDefaultAsync(c => c.ID == ID);

                    if (obj != null)
                    {
                        obj.Status = 0;
                        obj.DeleteDate = DateTime.Now;
                        obj.DeleteBy = IDUserdelete;

                        _dbcontext.Options.Attach(obj);
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

        public async Task<bool> UpdateAsync(Guid ID, OptionsUpdateVM request)
        {
            var checkVariant = await _dbcontext.ProductDetails.FirstOrDefaultAsync(c => c.ID == request.IDProductDetails);
            var checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == request.IDColor);
            var checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == request.IDSize);

            if (checkVariant == null)
            {
                return false;
            }

            if (checkSizes == null && !string.IsNullOrEmpty(request.SizesName))
            {
                request.IDSize = await EnsureSize(request.SizesName, request.ModifiedBy);
            }

            if (checkColor == null && !string.IsNullOrEmpty(request.ColorName))
            {
                request.IDColor = await EnsureColor(request.ColorName, request.ModifiedBy);
            }

            checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == request.IDColor);
            checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == request.IDSize);

            var option = await _dbcontext.Options.FindAsync(ID);

            if (option == null)
            {
                return false;
            }

            option.IDProductDetails = checkVariant.ID;
            option.IDColor = checkColor.ID;
            option.IDSize = checkSizes.ID;
            option.StockQuantity = request.StockQuantity;
            option.CostPrice = request.CostPrice;
            option.RetailPrice = request.RetailPrice;
            option.Discount = request.Discount;
            option.Status = request.Status;

            _dbcontext.Options.Update(option);
            await _dbcontext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> CreateSingle(OptionsCreateSingleVM request)
        {
            var checkvariant = await _dbcontext.ProductDetails.FirstOrDefaultAsync(c => c.ID == request.IDProductDetails);
            var checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == request.IDColor);
            var checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == request.IDSize);

            if (checkvariant == null)
            {
                return false;
            }
            if (checkSizes == null && !string.IsNullOrEmpty(request.SizesName))
            {
                request.IDSize = await EnsureSize(request.SizesName, request.CreateBy);
            }

            if (checkColor == null && !string.IsNullOrEmpty(request.ColorName))
            {
                request.IDColor = await EnsureColor(request.ColorName, request.CreateBy);
            }
            checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == request.IDColor);
            checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == request.IDSize);
            var option = new Options
            {
                ID = Guid.NewGuid(),
                IDProductDetails = checkvariant.ID,
                IDColor = checkColor.ID,
                IDSize = checkSizes.ID,
                StockQuantity = request.StockQuantity,
                RetailPrice = request.RetailPrice,
                CostPrice = request.CostPrice,
                Discount = request.Discount,
                Status = 1,
                CreateBy = request.CreateBy,
            };
            _dbcontext.Options.Add(option);

            var cloudinaryUrl = await UploadImageToCloudinary(request.ImageURL);

            if (!string.IsNullOrEmpty(cloudinaryUrl))
            {
                option.ImageURL = cloudinaryUrl; // Lưu URL của ảnh vào Options

                await _dbcontext.SaveChangesAsync(); // Lưu vào cơ sở dữ liệu
                return true;
            }
            else
            {
                return false;
            }
            return true;
        }
        public async Task<string> UploadImageToCloudinary(IFormFile file)
        {
            var uploadParams = new ImageUploadParams
            {
                File = new FileDescription(file.FileName, file.OpenReadStream()),
            };

            try
            {
                var uploadResult = await _cloudinary.UploadAsync(uploadParams);
                return uploadResult.SecureUrl.AbsoluteUri;
            }
            catch (Exception)
            {
                return "Không thể upload hình ảnh";
            }
        }
    }
}
