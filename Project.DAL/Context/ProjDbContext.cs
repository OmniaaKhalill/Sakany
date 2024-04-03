using Microsoft.EntityFrameworkCore;
using Project.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Context
{
    public class ProjDbContext:DbContext
    {

        public ProjDbContext(DbContextOptions options) : base(options)
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RenterService>().HasKey(c => new { c.RenterId, c.ServiceId});


            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Building> buildings { get; set; }

        public DbSet<Floor> Floors { get; set; }    
        public DbSet<Manager> Manager { get; set; }

        public DbSet<Renter> Renters { get; set; }
        public DbSet<Room> Rooms { get; set; }

        public DbSet<Service> Services { get; set; }
        public DbSet<RenterService> RenterServices { get; set; }    

      
        

    }

}
