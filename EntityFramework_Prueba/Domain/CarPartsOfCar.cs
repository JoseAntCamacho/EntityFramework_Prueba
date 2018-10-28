using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFramework_Prueba
{
    public class CarPartsOfCar
    {
        [Key]
        [Column(Order =0)]
        public Guid CarId { get; set; }
        [Key]
        [Column(Order = 1)]
        public Guid PartId { get; set; }        

        public virtual Car Car { get; set; }
        public virtual PartsOfCar PartsOfCar { get; set; }        

    }
}
