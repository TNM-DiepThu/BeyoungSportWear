using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using DataAccessLayer.Entity;
using DataAccessLayer.Configurations;

namespace DataAccessLayer.Application
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDBContext()
        {
        }
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(
                    "Data Source=.;Initial Catalog=BeyoungSportWear;Integrated Security=True;TrustServerCertificate=True"
                );
            }
        }
        //public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken))
        //{
        //    var orderEntries = ChangeTracker
        //        .Entries()
        //        .Where(e => e.Entity is Order && (e.State == EntityState.Added || e.State == EntityState.Modified));

        //    foreach (var entry in orderEntries)
        //    {
        //        var orderHistory = new OrderHistory
        //        {
        //            IDUser = entry.CurrentValues["IDUser"]?.ToString(),
        //            IDOrder = (Guid)entry.CurrentValues["ID"],
        //            EditingHistory = "Order created",
        //            ChangeDate = DateTime.Now,
        //            ChangeType = "Creation",
        //            OldStatus = 0, 
        //            NewStatus = 1,
        //            ChangeDetails = "New order created" 
        //        };

        //        OrderHistory.Add(orderHistory);
        //    }

        //    return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUser>()
             .ToTable("AspNetUsers")
             .HasIndex(u => u.Email)
             .IsUnique();
            //modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new AddressConfiguration());
            modelBuilder.ApplyConfiguration(new OptionsConfiguration());
            modelBuilder.ApplyConfiguration(new BrandConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new CartProductDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ColorsConfiguration());
            modelBuilder.ApplyConfiguration(new ImagesConfiguration());
            modelBuilder.ApplyConfiguration(new ManufacturerConfiguration());
            modelBuilder.ApplyConfiguration(new MaterialConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new OrderHistoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new ProductDetailsConfiguration());
            modelBuilder.ApplyConfiguration(new VoucherConfiguration());
            modelBuilder.ApplyConfiguration(new VoucherUserConfiguration());
            base.OnModelCreating(modelBuilder);
            CreateRoles(modelBuilder);
            CreateColor(modelBuilder);
            CreateUsers(modelBuilder);
            CreateSizes(modelBuilder);

        }
        private void CreateRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                    new IdentityRole() { Name = "Admin", NormalizedName = "Admin" },
                    new IdentityRole() { Name = "Client", NormalizedName = "Client" }
                );
        }
        private void CreateUsers(ModelBuilder builder)
        {
            builder.Entity<IdentityUser>().HasData(
                    new IdentityUser()
                    {
                        UserName = "admin",
                        NormalizedUserName = "admin",
                        Email = "admin@gmail.com",
                        NormalizedEmail = "admin@gmail.com",
                        EmailConfirmed = true,
                        PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "admin@123")
                    }
                );
        }

        private void CreateColor(ModelBuilder builder)
        {
            builder.Entity<Colors>().HasData(
                    new Colors() { ID = Guid.NewGuid(), Name = "White", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Colors() { ID = Guid.NewGuid(), Name = "Black", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Colors() { ID = Guid.NewGuid(), Name = "Red", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Colors() { ID = Guid.NewGuid(), Name = "Blue", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Colors() { ID = Guid.NewGuid(), Name = "Green", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 }
                );
        }
        private void CreateSizes(ModelBuilder builder)
        {
            builder.Entity<Sizes>().HasData(
                    new Sizes() { ID = Guid.NewGuid(), Name = "XS", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Sizes() { ID = Guid.NewGuid(), Name = "S", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Sizes() { ID = Guid.NewGuid(), Name = "M", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Sizes() { ID = Guid.NewGuid(), Name = "L", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 },
                    new Sizes() { ID = Guid.NewGuid(), Name = "XL", Description = "", CreateBy = "", CreateDate = DateTime.Now, Status = 1 }
                );
        }

        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; } = null!;
        public virtual DbSet<Brand> Brand { get; set; } = null!;
        public virtual DbSet<Options> Options { get; set; } = null!;
        public virtual DbSet<Cart> Cart { get; set; } = null!;
        public virtual DbSet<Address> Address { get; set; } = null!;
        public virtual DbSet<CartProductDetails> CartProductDetails { get; set; } = null!;
        public virtual DbSet<Category> Category { get; set; } = null!;
        public virtual DbSet<Colors> Colors { get; set; } = null!;
        public virtual DbSet<Images> Images { get; set; } = null!;
        public virtual DbSet<Manufacturer> Manufacturer { get; set; } = null!;
        public virtual DbSet<Material> Material { get; set; } = null!;
        public virtual DbSet<Order> Order { get; set; } = null!;
        public virtual DbSet<OrderDetails> OrderDetails { get; set; } = null!;
        public virtual DbSet<OrderHistory> OrderHistory { get; set; } = null!;
        public virtual DbSet<Product> Product { get; set; } = null!;
        public virtual DbSet<ProductDetails> ProductDetails { get; set; } = null!;
        public virtual DbSet<Sizes> Sizes { get; set; } = null!;
        public virtual DbSet<Voucher> Voucher { get; set; } = null!;
        public virtual DbSet<VoucherUser> VoucherUser { get; set; } = null!;
    }
}
