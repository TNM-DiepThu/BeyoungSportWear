using AutoMapper;
using Azure.Core;
using BusinessLogicLayer.Services.Interface;
using BusinessLogicLayer.Viewmodels.Image;
using BusinessLogicLayer.Viewmodels.Manufacturer;
using BusinessLogicLayer.Viewmodels.Options;
using BusinessLogicLayer.Viewmodels.ProductDetails;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using DataAccessLayer.Application;
using DataAccessLayer.Entity;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using System.Text;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace BusinessLogicLayer.Services.Implements
{
    public class ProductDetailsService : IProductDetailsService
    {

        private readonly ApplicationDBContext _dbcontext;
        private readonly IMapper _mapper;
        private readonly Cloudinary _cloudinary;

        public ProductDetailsService(ApplicationDBContext ApplicationDBContext, IMapper mapper, Cloudinary Cloudinary)
        {
            _cloudinary = Cloudinary;
            _dbcontext = ApplicationDBContext;
            _mapper = mapper;
        }
        public async Task<Guid> EnsureCategory(string CategoryName, string CreateBy)
        {
            var category = await _dbcontext.Category
                .FirstOrDefaultAsync(s => s.Name.ToLower() == CategoryName.ToLower());

            if (category == null)
            {
                category = new Category
                {
                    ID = Guid.NewGuid(),
                    Name = CategoryName,
                    Status = 1,
                    CreateBy = CreateBy,
                    CreateDate = DateTime.Now
                };
                await _dbcontext.Category.AddAsync(category);
                await _dbcontext.SaveChangesAsync();
            }

            return category.ID;
        }
        public async Task<Guid> EnsureBrand(string BrandName, string CreateBy)
        {
            var brand = await _dbcontext.Brand
                .FirstOrDefaultAsync(c => c.Name.ToLower() == BrandName.ToLower());

            if (brand == null)
            {
                brand = new Brand
                {
                    ID = Guid.NewGuid(),
                    Name = BrandName,
                    Description = "",
                    Address = "",
                    Phone = "",
                    Gmail = "",
                    Website = "",
                    Status = 1,
                    CreateBy = CreateBy,
                    CreateDate = DateTime.Now
                };
                await _dbcontext.Brand.AddAsync(brand);
                await _dbcontext.SaveChangesAsync();
            }

            return brand.ID;
        }
        public async Task<Guid> EnsureManufacturers(string ManufacturersName, string CreateBy)
        {
            var manufacturers = await _dbcontext.Manufacturer
                .FirstOrDefaultAsync(c => c.Name.ToLower() == ManufacturersName.ToLower());

            if (manufacturers == null)
            {
                manufacturers = new Manufacturer
                {
                    ID = Guid.NewGuid(),
                    Name = ManufacturersName,
                    Description = "",
                    Address = "",
                    Phone = "",
                    Gmail = "",
                    Website = "",
                    Status = 1,
                    CreateDate = DateTime.Now,
                    CreateBy = CreateBy,
                };
                await _dbcontext.Manufacturer.AddAsync(manufacturers);
                await _dbcontext.SaveChangesAsync();
            }

            return manufacturers.ID;
        }
        public async Task<Guid> EnsureMaterial(string materialName, string CreateBy)
        {
            var material = await _dbcontext.Material
                .FirstOrDefaultAsync(c => c.Name.ToLower() == materialName.ToLower());

            if (material == null)
            {
                material = new Material
                {
                    ID = Guid.NewGuid(),
                    Name = materialName,
                    Status = 1,
                    CreateDate = DateTime.Now,
                    CreateBy = CreateBy,
                };
                await _dbcontext.Material.AddAsync(material);
                await _dbcontext.SaveChangesAsync();
            }

            return material.ID;
        }
        public async Task<Guid> EnsureProduct(string productTypeName, string CreateBy)
        {
            var productType = await _dbcontext.Product
                .FirstOrDefaultAsync(c => c.Name.ToLower() == productTypeName.ToLower());

            if (productType == null)
            {
                productType = new Product
                {
                    ID = Guid.NewGuid(),
                    Name = productTypeName,
                    Status = 1,
                    CreateDate = DateTime.Now,
                    CreateBy = CreateBy,
                };
                await _dbcontext.Product.AddAsync(productType);
                await _dbcontext.SaveChangesAsync();
            }

            return productType.ID;
        }
        public async Task<Guid> EnsureSize(string sizeName, string CreateBy)
        {
            var size = await _dbcontext.Sizes
                .FirstOrDefaultAsync(s => s.Name.ToLower() == sizeName.ToLower());

            if (size == null)
            {
                size = new Sizes
                {
                    ID = Guid.NewGuid(),
                    Name = sizeName,
                    CreateDate = DateTime.Now,
                    CreateBy = CreateBy,
                    Status = 1
                };
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
                color = new Colors
                {
                    ID = Guid.NewGuid(),
                    Name = colorName,
                    CreateDate = DateTime.Now,
                    CreateBy = CreateBy,
                    Status = 1
                };
                await _dbcontext.Colors.AddAsync(color);
                await _dbcontext.SaveChangesAsync();
            }

            return color.ID;
        }
        private string GenerateKeyCode(string productName)
        {
            string normalizedProductName = RemoveDiacritics(productName);
            string keyPart = GetInitials(normalizedProductName);
            var random = new Random();
            string keyCode = $"{keyPart}-{random.Next(1000, 9999)}";

            return keyCode.ToUpper();
        }
        private string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
        private string GetInitials(string text)
        {
            var words = text.Split(' ');
            var initials = new StringBuilder();

            foreach (var word in words)
            {
                if (!string.IsNullOrEmpty(word) && char.IsLetterOrDigit(word[0]))
                {
                    initials.Append(word[0]);
                }
            }

            return initials.ToString().ToUpper();
        }
        public async Task<bool> CreateAsync(ProductDetailsCreateVM request)
        {
            using (var transaction = await _dbcontext.Database.BeginTransactionAsync())
            {
                try
                {
                    var checkBrand = await _dbcontext.Brand.FirstOrDefaultAsync(c => c.ID == request.IDBrand);
                    var checkMaterial = await _dbcontext.Material.FirstOrDefaultAsync(c => c.ID == request.IDMaterial);
                    var checkManufacturer = await _dbcontext.Manufacturer.FirstOrDefaultAsync(c => c.ID == request.IDManufacturers);
                    var checkProduct = await _dbcontext.Product.FirstOrDefaultAsync(c => c.ID == request.IDProduct);
                    var checkCategory = await _dbcontext.Category.FirstOrDefaultAsync(c => c.ID == request.IDCategory);

                    if (checkBrand == null && !string.IsNullOrEmpty(request.BrandName))
                    {
                        request.IDBrand = await EnsureBrand(request.BrandName, request.CreateBy);
                    }
                    if (checkCategory == null && !string.IsNullOrEmpty(request.CategoryName))
                    {
                        request.IDCategory = await EnsureCategory(request.CategoryName, request.CreateBy);
                    }

                    if (checkProduct == null && !string.IsNullOrEmpty(request.ProductName))
                    {
                        request.IDProduct = await EnsureProduct(request.ProductName, request.CreateBy);
                    }

                    if (checkMaterial == null && !string.IsNullOrEmpty(request.MaterialName))
                    {
                        request.IDMaterial = await EnsureMaterial(request.MaterialName, request.CreateBy);
                    }

                    if (checkManufacturer == null && !string.IsNullOrEmpty(request.ManufacturersName))
                    {
                        request.IDManufacturers = await EnsureManufacturers(request.ManufacturersName, request.CreateBy);
                    }

                    checkBrand = await _dbcontext.Brand.FirstOrDefaultAsync(c => c.ID == request.IDBrand);
                    checkMaterial = await _dbcontext.Material.FirstOrDefaultAsync(c => c.ID == request.IDMaterial);
                    checkManufacturer = await _dbcontext.Manufacturer.FirstOrDefaultAsync(c => c.ID == request.IDManufacturers);
                    checkProduct = await _dbcontext.Product.FirstOrDefaultAsync(c => c.ID == request.IDProduct);
                    checkCategory = await _dbcontext.Category.FirstOrDefaultAsync(c => c.ID == request.IDCategory);

                    if (checkBrand == null || checkMaterial == null || checkManufacturer == null || checkProduct == null || checkCategory == null)
                    {
                        throw new Exception("Brand, Material, Manufacturer, Category or Product not found.");
                    }


                    var productDetails = new ProductDetails
                    {
                        ID = Guid.NewGuid(),
                        IDMaterial = checkMaterial.ID,
                        IDBrand = checkBrand.ID,
                        IDManufacturers = checkManufacturer.ID,
                        IDProduct = checkProduct.ID,
                        IDCategory = checkCategory.ID,
                        Origin = request.Origin,
                        Style = request.Style,
                        KeyCode = GenerateKeyCode(request.ProductName),
                        Description = request.Description,
                        CreateBy = request.CreateBy,
                        CreateDate = DateTime.Now,
                        Status = 1,
                    };
                    await _dbcontext.ProductDetails.AddAsync(productDetails);
                    foreach (var imageUrl in request.ImagePaths)
                    {
                        var imageEntity = new Images
                        {
                            ID = Guid.NewGuid(),
                            IDProductDetails = productDetails.ID,
                            Path = imageUrl,
                            Status = 1,
                            CreateDate = DateTime.Now,
                            CreateBy = ""
                        };

                        await _dbcontext.Images.AddAsync(imageEntity);
                    }
                    if (request.OptionsCreateVM == null || !request.OptionsCreateVM.Any())
                    {
                        throw new Exception("OptionsCreateVM is null or empty");
                    }

                    foreach (var option in request.OptionsCreateVM)
                    {
                        var checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == option.IDColor);
                        var checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == option.IDSize);

                        if (checkSizes == null && !string.IsNullOrEmpty(option.SizesName))
                        {
                            option.IDSize = await EnsureSize(option.SizesName, request.CreateBy);
                        }

                        if (checkColor == null && !string.IsNullOrEmpty(option.ColorName))
                        {
                            option.IDColor = await EnsureColor(option.ColorName, request.CreateBy);
                        }

                        checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == option.IDColor);
                        checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == option.IDSize);

                        if (checkColor == null || checkSizes == null)
                        {
                            throw new Exception("Color or Size not found.");
                        }

                        var options = new Options
                        {
                            ID = Guid.NewGuid(),
                            IDProductDetails = productDetails.ID,
                            IDColor = checkColor.ID,
                            IDSize = checkSizes.ID,
                            StockQuantity = option.StockQuantity,
                            CostPrice = option.CostPrice,
                            RetailPrice = option.RetailPrice,
                            ImageURL = option.ImageURL,
                            CreateBy = request.CreateBy,
                            CreateDate = DateTime.Now,
                            Status = 1
                        };
                        _dbcontext.Options.Add(options);
                    }
                    await _dbcontext.SaveChangesAsync();


                    await _dbcontext.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Error creating product details", ex);
                }
            }
        }
        public async Task<List<ProductDetailsVM>> GetAllActiveAsync()
        {
            var activeVariants = await _dbcontext.ProductDetails.Where(c => c.Status != 0)
              .AsNoTracking()
              .Select(v => new
              {
                  ProductDetails = v,
                  Product = v.Products,
                  Brand = v.Brand,
                  Material = v.Material,
                  Category = v.Category,
                  Options = v.Options,
                  Manufacturers = v.Manufacturers,
                  Images = v.Images.Where(m => m.Status == 1)
              }).ToListAsync();

            var variantsVMList = activeVariants.Select(v =>
            {
                return new ProductDetailsVM
                {
                    ID = v.ProductDetails.ID,
                    ProductName = v.Product.Name,
                    BrandName = v.Brand.Name,
                    CategoryName = v.Category.Name,
                    TotalQuantity = v.Options.Sum(opt => opt.StockQuantity),
                    ManufacturersName = v.Manufacturers.Name,
                    MaterialName = v.Material.Name,
                    KeyCode = v.ProductDetails.KeyCode,
                    Description = v.ProductDetails.Description,
                    Origin = v.ProductDetails.Origin,
                    Status = v.ProductDetails.Status,
                    SmallestPrice = v.Options.Any() ? v.Options.Min(opt => opt.RetailPrice) : 0,
                    BiggestPrice = v.Options.Any() ? v.Options.Max(opt => opt.RetailPrice) : 0,
                    ImagePaths = v.Images.Select(m => m.Path).ToList(),
                };
            }).ToList();

            return variantsVMList;
        }
        public async Task<List<ProductDetailsVM>> GetAllAsync()
        {
            var result = await (from pd in _dbcontext.ProductDetails
                                join p in _dbcontext.Product on pd.IDProduct equals p.ID
                                join c in _dbcontext.Category on pd.IDCategory equals c.ID
                                join m in _dbcontext.Manufacturer on pd.IDManufacturers equals m.ID
                                join mt in _dbcontext.Material on pd.IDMaterial equals mt.ID
                                join b in _dbcontext.Brand on pd.IDBrand equals b.ID
                                select new ProductDetailsVM
                                {
                                    ID = pd.ID,
                                    CreateBy = pd.CreateBy,
                                    CreateDate = pd.CreateDate,
                                    IDProduct = p.ID,
                                    ProductName = p.Name,
                                    IDCategory = c.ID,
                                    CategoryName = c.Name,
                                    IDManufacturers = m.ID,
                                    ManufacturersName = m.Name,
                                    IDMaterial = mt.ID,
                                    MaterialName = mt.Name,
                                    IDBrand = b.ID,
                                    SmallestPrice = pd.Options.Any() ? pd.Options.Min(opt => opt.RetailPrice) : 0,
                                    BiggestPrice = pd.Options.Any() ? pd.Options.Max(opt => opt.RetailPrice) : 0,

                                    BrandName = b.Name,
                                    KeyCode = pd.KeyCode,
                                    Description = pd.Description,
                                    Style = pd.Style,
                                    Origin = pd.Origin,
                                    ImagePaths = (from img in _dbcontext.Images
                                                  where img.IDProductDetails == pd.ID
                                                  select img.Path).ToList(),
                                    Status = pd.Status,
                                }).ToListAsync();
            return result;
        }
        public async Task<ProductDetailsVM> GetByIDAsync(Guid ID)
        {
            var result = await (from pd in _dbcontext.ProductDetails
                                join p in _dbcontext.Product on pd.IDProduct equals p.ID
                                join c in _dbcontext.Category on pd.IDCategory equals c.ID
                                join m in _dbcontext.Manufacturer on pd.IDManufacturers equals m.ID
                                join mt in _dbcontext.Material on pd.IDMaterial equals mt.ID
                                join b in _dbcontext.Brand on pd.IDBrand equals b.ID
                                where pd.ID == ID
                                select new ProductDetailsVM
                                {
                                    ID = pd.ID,
                                    CreateBy = pd.CreateBy,
                                    CreateDate = pd.CreateDate,
                                    IDProduct = p.ID,
                                    SmallestPrice = pd.Options.Any() ? pd.Options.Min(opt => opt.RetailPrice) : 0,
                                    BiggestPrice = pd.Options.Any() ? pd.Options.Max(opt => opt.RetailPrice) : 0,
                                    ProductName = p.Name,
                                    IDCategory = c.ID,
                                    CategoryName = c.Name,
                                    IDManufacturers = m.ID,
                                    ManufacturersName = m.Name,
                                    IDMaterial = mt.ID,
                                    KeyCode = pd.KeyCode,
                                    MaterialName = mt.Name,
                                    IDBrand = b.ID,
                                    BrandName = b.Name,
                                    Description = pd.Description,
                                    Style = pd.Style,
                                    Origin = pd.Origin,
                                    ImagePaths = (from img in _dbcontext.Images
                                                  where img.IDProductDetails == pd.ID
                                                  select img.Path).ToList(),
                                    Status = pd.Status,
                                    Options = (from o in _dbcontext.Options
                                               join col in _dbcontext.Colors on o.IDColor equals col.ID
                                               join siz in _dbcontext.Sizes on o.IDSize equals siz.ID
                                               where o.IDProductDetails == pd.ID
                                               select new OptionsVM
                                               {
                                                   ID = o.ID,
                                                   IDColor = col.ID,
                                                   ColorName = col.Name,
                                                   IDSize = siz.ID,
                                                   SizesName = siz.Name,
                                                   StockQuantity = o.StockQuantity,
                                                   CostPrice = o.CostPrice,
                                                   RetailPrice = o.RetailPrice,
                                                   ImageURL = o.ImageURL,
                                                   CreateDate = o.CreateDate,
                                                   CreateBy = o.CreateBy,
                                                   Status = o.Status,
                                               }).ToList()
                                }).FirstOrDefaultAsync();

            return result;
        }
        public Task<List<OptionsVM>> GetOptionProductDetailsByIDAsync(Guid IDProductDetails)
        {
            throw new NotImplementedException();
        }
        public async Task<bool> RemoveAsync(Guid ID, string IDUserDelete)
        {
            using (var transaction = _dbcontext.Database.BeginTransaction())
            {
                try
                {
                    var obj = await _dbcontext.ProductDetails.FirstOrDefaultAsync(c => c.ID == ID);

                    if (obj != null)
                    {
                        obj.Status = 0;
                        obj.DeleteDate = DateTime.Now;
                        obj.DeleteBy = IDUserDelete;

                        _dbcontext.ProductDetails.Attach(obj);
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
        public async Task<bool> UpdateAsync(Guid ID, ProductDetailsUpdateVM request)
        {
            using (var transaction = await _dbcontext.Database.BeginTransactionAsync())
            {
                try
                {
                    var productDetail = await _dbcontext.ProductDetails.FirstOrDefaultAsync(pd => pd.ID == ID);

                    if (productDetail == null)
                    {
                        return false;
                    }

                    var checkBrand = await _dbcontext.Brand.FirstOrDefaultAsync(c => c.ID == request.IDBrand);
                    var checkMaterial = await _dbcontext.Material.FirstOrDefaultAsync(c => c.ID == request.IDMaterial);
                    var checkManufacturer = await _dbcontext.Manufacturer.FirstOrDefaultAsync(c => c.ID == request.IDManufacturers);
                    var checkProduct = await _dbcontext.Product.FirstOrDefaultAsync(c => c.ID == request.IDProduct);
                    var checkCategory = await _dbcontext.Category.FirstOrDefaultAsync(c => c.ID == request.IDCategory);

                    if (checkBrand == null && !string.IsNullOrEmpty(request.BrandName))
                    {
                        request.IDBrand = await EnsureBrand(request.BrandName, request.ModifiedBy);
                    }
                    if (checkCategory == null && !string.IsNullOrEmpty(request.CategoryName))
                    {
                        request.IDCategory = await EnsureCategory(request.CategoryName, request.ModifiedBy);
                    }
                    if (checkProduct == null && !string.IsNullOrEmpty(request.ProductName))
                    {
                        request.IDProduct = await EnsureProduct(request.ProductName, request.ModifiedBy);
                    }
                    if (checkMaterial == null && !string.IsNullOrEmpty(request.MaterialName))
                    {
                        request.IDMaterial = await EnsureMaterial(request.MaterialName, request.ModifiedBy);
                    }
                    if (checkManufacturer == null && !string.IsNullOrEmpty(request.ManufacturersName))
                    {
                        request.IDManufacturers = await EnsureManufacturers(request.ManufacturersName, request.ModifiedBy);
                    }

                    checkBrand = await _dbcontext.Brand.FirstOrDefaultAsync(c => c.ID == request.IDBrand);
                    checkMaterial = await _dbcontext.Material.FirstOrDefaultAsync(c => c.ID == request.IDMaterial);
                    checkManufacturer = await _dbcontext.Manufacturer.FirstOrDefaultAsync(c => c.ID == request.IDManufacturers);
                    checkProduct = await _dbcontext.Product.FirstOrDefaultAsync(c => c.ID == request.IDProduct);
                    checkCategory = await _dbcontext.Category.FirstOrDefaultAsync(c => c.ID == request.IDCategory);

                    if (checkBrand == null || checkMaterial == null || checkManufacturer == null || checkProduct == null || checkCategory == null)
                    {
                        throw new Exception("Brand, Material, Manufacturer, Category or Product not found.");
                    }

                    productDetail.Description = request.Description;
                    productDetail.Style = request.Style;
                    productDetail.Origin = request.Origin;
                    productDetail.IDBrand = checkBrand.ID;
                    productDetail.IDCategory = checkCategory.ID;
                    productDetail.IDManufacturers = checkManufacturer.ID;
                    productDetail.IDMaterial = checkMaterial.ID;
                    productDetail.IDProduct = checkProduct.ID;
                    productDetail.Status = request.Status;

                    productDetail.ModifiedBy = request.ModifiedBy;
                    productDetail.ModifiedDate = DateTime.Now;
                    foreach (var imageUrl in request.ImagePaths)
                    {
                        var imageEntity = new Images
                        {
                            ID = Guid.NewGuid(),
                            IDProductDetails = productDetail.ID,
                            Path = imageUrl,
                            Status = 1,
                            CreateDate = DateTime.Now,
                            CreateBy = ""
                        };

                        await _dbcontext.Images.AddAsync(imageEntity);
                    }
                    var existingOptions = await _dbcontext.Options.Where(o => o.IDProductDetails == productDetail.ID).ToListAsync();
                    var existingOptionIds = existingOptions.Select(o => o.ID).ToList();

                    var updatedOptionIds = request.OptionsUpdateVM.Select(o => o.ID).ToList();

                    var optionsToDelete = existingOptions.Where(o => !updatedOptionIds.Contains(o.ID)).ToList();
                    _dbcontext.Options.RemoveRange(optionsToDelete);

                    foreach (var option in request.OptionsUpdateVM)
                    {
                        var checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == option.IDColor);
                        var checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == option.IDSize);

                        if (checkSizes == null && !string.IsNullOrEmpty(option.SizesName))
                        {
                            option.IDSize = await EnsureSize(option.SizesName, request.ModifiedBy);
                        }

                        if (checkColor == null && !string.IsNullOrEmpty(option.ColorName))
                        {
                            option.IDColor = await EnsureColor(option.ColorName, request.ModifiedBy);
                        }

                        checkColor = await _dbcontext.Colors.FirstOrDefaultAsync(c => c.ID == option.IDColor);
                        checkSizes = await _dbcontext.Sizes.FirstOrDefaultAsync(c => c.ID == option.IDSize);

                        if (checkColor == null || checkSizes == null)
                        {
                            throw new Exception("Color or Size not found.");
                        }
                        var existingOption = existingOptions.FirstOrDefault(o => o.ID == option.ID);
                        if (existingOption != null)
                        {
                            existingOption.IDColor = checkColor.ID;
                            existingOption.IDSize = checkSizes.ID;
                            existingOption.StockQuantity = option.StockQuantity;
                            existingOption.CostPrice = option.CostPrice;
                            existingOption.RetailPrice = option.RetailPrice;
                            existingOption.Discount = option.Discount;
                            existingOption.Status = 1;
                        }
                        else
                        {
                            var newOption = new Options
                            {
                                ID = option.ID == Guid.Empty ? Guid.NewGuid() : option.ID,
                                IDProductDetails = productDetail.ID,
                                IDColor = checkColor.ID,
                                IDSize = checkSizes.ID,
                                StockQuantity = option.StockQuantity,
                                RetailPrice = option.RetailPrice,
                                CostPrice = option.CostPrice,
                                Discount = option.Discount,
                                ImageURL = option.ImageURL,
                                CreateDate = DateTime.Now,
                                CreateBy = request.ModifiedBy,
                                Status = 1
                            };
                            _dbcontext.Options.Add(newOption);
                            existingOptions.Add(newOption);
                        }
                    }

                    await _dbcontext.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Error updating product details", ex);
                }
            }
        }

        public async Task<bool> CreateSingle(ProductDetailsSingleCreateVM request)
        {
            using (var transaction = await _dbcontext.Database.BeginTransactionAsync())
            {
                try
                {
                    var checkBrand = await _dbcontext.Brand.FirstOrDefaultAsync(c => c.ID == request.IDBrand);
                    var checkMaterial = await _dbcontext.Material.FirstOrDefaultAsync(c => c.ID == request.IDMaterial);
                    var checkManufacturer = await _dbcontext.Manufacturer.FirstOrDefaultAsync(c => c.ID == request.IDManufacturers);
                    var checkProduct = await _dbcontext.Product.FirstOrDefaultAsync(c => c.ID == request.IDProduct);
                    var checkCategory = await _dbcontext.Category.FirstOrDefaultAsync(c => c.ID == request.IDCategory);

                    if (checkBrand == null && !string.IsNullOrEmpty(request.BrandName))
                    {
                        request.IDBrand = await EnsureBrand(request.BrandName, request.CreateBy);
                    }
                    if (checkCategory == null && !string.IsNullOrEmpty(request.CategoryName))
                    {
                        request.IDCategory = await EnsureCategory(request.CategoryName, request.CreateBy);
                    }

                    if (checkProduct == null && !string.IsNullOrEmpty(request.ProductName))
                    {
                        request.IDProduct = await EnsureProduct(request.ProductName, request.CreateBy);
                    }

                    if (checkMaterial == null && !string.IsNullOrEmpty(request.MaterialName))
                    {
                        request.IDMaterial = await EnsureMaterial(request.MaterialName, request.CreateBy);
                    }

                    if (checkManufacturer == null && !string.IsNullOrEmpty(request.ManufacturersName))
                    {
                        request.IDManufacturers = await EnsureManufacturers(request.ManufacturersName, request.CreateBy);
                    }

                    checkBrand = await _dbcontext.Brand.FirstOrDefaultAsync(c => c.ID == request.IDBrand);
                    checkMaterial = await _dbcontext.Material.FirstOrDefaultAsync(c => c.ID == request.IDMaterial);
                    checkManufacturer = await _dbcontext.Manufacturer.FirstOrDefaultAsync(c => c.ID == request.IDManufacturers);
                    checkProduct = await _dbcontext.Product.FirstOrDefaultAsync(c => c.ID == request.IDProduct);
                    checkCategory = await _dbcontext.Category.FirstOrDefaultAsync(c => c.ID == request.IDCategory);

                    if (checkBrand == null || checkMaterial == null || checkManufacturer == null || checkProduct == null || checkCategory == null)
                    {
                        throw new Exception("Brand, Material, Manufacturer, Category or Product not found.");
                    }


                    var productDetails = new ProductDetails
                    {
                        ID = Guid.NewGuid(),
                        IDMaterial = checkMaterial.ID,
                        IDBrand = checkBrand.ID,
                        IDManufacturers = checkManufacturer.ID,
                        IDProduct = checkProduct.ID,
                        IDCategory = checkCategory.ID,
                        Origin = request.Origin,
                        Style = request.Style,
                        KeyCode = GenerateKeyCode(request.ProductName),
                        Description = request.Description,
                        CreateBy = request.CreateBy,
                        CreateDate = DateTime.Now,
                        Status = 1,
                    };
                    await _dbcontext.ProductDetails.AddAsync(productDetails);
                    List<Guid> imageIds = new List<Guid>();

                    foreach (var file in request.ImagePaths)
                    {
                        var imageId = Guid.NewGuid();
                        var fileName = imageId.ToString() + Path.GetExtension(file.FileName);
                        using var stream = file.OpenReadStream();

                        var uploadParams = new ImageUploadParams()
                        {
                            File = new FileDescription(fileName, stream),
                            PublicId = imageId.ToString()
                        };

                        try
                        {
                            var uploadResult = await _cloudinary.UploadAsync(uploadParams);
                            var imageUrl = uploadResult.Url.ToString();

                            var imageEntity = new Images
                            {
                                ID = imageId,
                                IDProductDetails = productDetails.ID,
                                Path = imageUrl,
                                Status = 1,
                                CreateDate = DateTime.Now,
                                CreateBy = request.CreateBy
                            };

                            await _dbcontext.Images.AddAsync(imageEntity);
                        }
                        catch (Exception)
                        {

                        }
                    }

                    await _dbcontext.SaveChangesAsync();
                    await transaction.CommitAsync();

                    return true;
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    throw new Exception("Error creating product details", ex);
                }
            }
        }
    }
}
