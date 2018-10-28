using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace EntityFramework_Prueba
{
    public class CarPartsContext : DbContext
    {

        public DbSet<Car> Cars { get; set; }
        public DbSet<PartsOfCar> PartsOfCars { get; set; }
        public DbSet<CarPartsOfCar> CarPartsOfCars { get; set; }

        public CarPartsContext():base("DDBBCars")
        {

        }
        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>()
                        .HasMany(c => c.CarPartsOfCars)
                        .WithRequired();
            modelBuilder.Entity<PartsOfCar>()
                        .HasMany(c => c.CarPartsOfCars)
                        .WithRequired();
        }
    }
}
