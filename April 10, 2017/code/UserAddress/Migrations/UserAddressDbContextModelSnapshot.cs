using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using UserAddress.Data;

namespace UserAddress.Migrations
{
    [DbContext(typeof(UserAddressDbContext))]
    partial class UserAddressDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1");

            modelBuilder.Entity("UserAddress.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Updated");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("UserAddress.Models.AddressUser", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("AddressId");

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Updated");

                    b.HasKey("UserId", "AddressId");

                    b.HasIndex("AddressId");

                    b.ToTable("AddressUser");
                });

            modelBuilder.Entity("UserAddress.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("FullName");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("UserAddress.Models.AddressUser", b =>
                {
                    b.HasOne("UserAddress.Models.Address", "Address")
                        .WithMany("AddressUsers")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UserAddress.Models.User", "User")
                        .WithMany("AddressUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
