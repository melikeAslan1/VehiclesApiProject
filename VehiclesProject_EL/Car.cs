using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VehiclesProject_EL
{
    [Table("Cars")]
    public class Car:Vehicle
    {
        public int ColorId { get; set; }

        [Required]
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }

        [StringLength(50)]
        public string Wheels { get; set; }

        [Required]
        public bool Headlights { get; set; }
        
    }
}
