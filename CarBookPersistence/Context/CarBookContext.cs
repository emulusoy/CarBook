using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarBook.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarBookPersistence.Context
{
    public class CarBookContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MULUSOY\\SQLEXPRESS01;initial Catalog=CarBookDB;integrated security=true;TrustServerCertificate=True");
        }
        public DbSet<About> Abouts { get; set; }    
        public DbSet<Banner>  Banners{ get; set; }    
        public DbSet<Brand>  Brands{ get; set; }    
        public DbSet<Car>  Cars{ get; set; }    
        public DbSet<CarDescription> CarDescriptions { get; set; }    
        public DbSet<CarFeature>  CarFeatures{ get; set; }    
        public DbSet<CarPricing> CarPricings { get; set; }    
        public DbSet<Category> Categories { get; set; }    
        public DbSet<Contact> Contacts { get; set; }    
        public DbSet<Feature> Features { get; set; }      
        public DbSet<FooterAddress> FooterAddresses { get; set; }      
        public DbSet<Location> Locations { get; set; }      
        public DbSet<Pricing> Pricings { get; set; }      
        public DbSet<Service> Services { get; set; }         
        public DbSet<SocialMedia>  SocialMedias{ get; set; }         
        public DbSet<Testimonial>  Testimonials{ get; set; }         
        public DbSet<Blog>  Blogs{ get; set; }         
        public DbSet<Author> Authors{ get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<RentACarProcess> RentACarProcesses { get; set; }
        public DbSet<Customer> GetCustomers { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //iliski olusturma 2 tane id kullandigimiz icin bir taraftaki 2 idyi diger tarafaki tek id ile birlestirme
            //has foreigin key hangi sutunu iliskiledireceksin onu secer1

            modelBuilder.Entity<Reservation>().HasOne(x => x.PickUpLocation).WithMany(y => y.PickUpReservation).HasForeignKey(z => z.PickUpLocationID).OnDelete(DeleteBehavior.ClientSetNull);
            modelBuilder.Entity<Reservation>().HasOne(x => x.DropOffLocation).WithMany(y => y.DropOffReservation).HasForeignKey(z => z.DropOffLocationID).OnDelete(DeleteBehavior.ClientSetNull);
        }



    }
}
