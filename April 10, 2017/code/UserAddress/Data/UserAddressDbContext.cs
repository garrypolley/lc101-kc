using Microsoft.EntityFrameworkCore;
using UserAddress.Models;

namespace UserAddress.Data
{
    public class UserAddressDbContext : DbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Address> Addresses { get; set; }

        public UserAddressDbContext(DbContextOptions<UserAddressDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey( u => u.Id );
            modelBuilder.Entity<Address>().HasKey( a => a.Id );

            modelBuilder.Entity<AddressUser>()
                .HasKey(au => new { au.UserId, au.AddressId });

            modelBuilder.Entity<User>()
                .HasMany(u => u.AddressUsers);

            modelBuilder.Entity<Address>()
                .HasMany(a => a.AddressUsers);
        }
    }
}