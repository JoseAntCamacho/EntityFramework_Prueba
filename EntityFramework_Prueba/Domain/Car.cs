using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_Prueba
{
    public class Car
    {
        [Key]
        public Guid CarID { get; set; }
        [Required]
        public string CarBrand { get; set; }
        [Required]
        public string CarModel { get; set; }
        //public Decimal CarPrice { get; set; }

        public virtual ICollection<CarPartsOfCar> CarPartsOfCars { get; set; }

        public Car()
        {
            this.CarPartsOfCars = new HashSet<CarPartsOfCar>();
            //TODO: Calculate the price of the car.
        }
    }
}
