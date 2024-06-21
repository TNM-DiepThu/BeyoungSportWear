using AutoMapper;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.ViewKH;
using CloudinaryDotNet;
using DataAccessLayer.Application;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services.Implements
{
    public class ViewKHServiece : IViewKHServiece
    {
        private readonly ApplicationDBContext _dbcontex;
        private readonly IMapper _mapper;
        private readonly Cloudinary _cloudinary;

        public ViewKHServiece(ApplicationDBContext applicationDBContext, IMapper mapper, Cloudinary cloudinary)
        {
            _dbcontex = applicationDBContext;
            _mapper = mapper;
            _cloudinary = cloudinary;
        }
        public async Task<List<ProductVKH>> GetAll()
        {
            var productVKHList = await _dbcontex.ProductDetails
            .Include(pd => pd.Options)
            .Include(pd => pd.Images)
            .Include(pd => pd.Products)
            .Select(pd => new ProductVKH
            {
                Id = pd.IDProduct,
                Name = pd.Products.Name,
                CostPrie = pd.Options.FirstOrDefault() != null ? pd.Options.FirstOrDefault().CostPrice : 0,
                urlImg = pd.Images.FirstOrDefault() != null ? pd.Images.FirstOrDefault().Path : null
            })
    .ToListAsync();

            return productVKHList;
        }

        public Task<List<ProductVKH>> GetAllPro()
        {
            throw new NotImplementedException();
        }

        public async Task<ProDetailKH> GetProDetail(Guid id)
        {

            var productDetails = await _dbcontex.ProductDetails
        .Where(pd => pd.IDProduct == id)
        .Include(pd => pd.Products)
            .ThenInclude(p => p.Name)
        .Include(pd => pd.Options)
            .ThenInclude(o => o.Colors)
        .Include(pd => pd.Options)
            .ThenInclude(o => o.Sizes)
        .Include(pd => pd.Images)
        .FirstOrDefaultAsync();

            if (productDetails == null)
            {
                throw new KeyNotFoundException("Không tìm thấy sản phẩm.");
            }

            var option = productDetails.Options.FirstOrDefault();
            var size = option?.Sizes.Name ?? "N/A";
            var color = option?.Colors.Name ?? "N/A";
            var image = productDetails.Images.FirstOrDefault()?.Path ?? "N/A";

            var price = option?.CostPrice ?? 0;
            var description = productDetails.Description;

            return new ProDetailKH
            {
                ID = productDetails.ID,
                Name = productDetails.Products.Name,
                Price = price,
                Description = description,
                Size = size,
                Color = color,
                UrlImg = image  
            };
        }
    }
}
