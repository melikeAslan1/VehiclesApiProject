using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehiclesProject_EL
{
    [Table("Busses")]
    public class Bus:Vehicle
    {
        public int ColorId { get; set; }

        [Required]
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }
    }
}
