using Microsoft.EntityFrameworkCore;
using System;
using VehiclesProject_EL;

namespace VehiclesProject_DAL
{
    public class MyDBContext:DbContext
    {
        //string a = "Data Source=DESKTOP-6VNQSHU;Initial Catalog=VehiclesWebApiProjectDB;Integrated Security=True;MultipleActiveResultSets=True";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(a);
        //}

        public MyDBContext(DbContextOptions<MyDBContext> options)
            : base(options)
        {




        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Bus> Busses { get; set; }
        public DbSet<Boat> Boats { get; set; }
    }
}
