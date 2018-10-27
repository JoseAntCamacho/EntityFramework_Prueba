using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_Prueba
{
    public class PartsOfCar
    {
        [Key]
        public Guid PartCarID { get; set; }
        [Required]
        public string PartName { get; set; }
        public Decimal PartPrice { get; set; }

        public virtual ICollection<CarPartsOfCar> CarPartsOfCars { get; set; }

        public PartsOfCar()
        {
            this.CarPartsOfCars = new HashSet<CarPartsOfCar>();            
        }
    }
}
