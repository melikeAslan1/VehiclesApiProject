using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VehiclesProject_EL
{
    public abstract class Vehicle
    {
        [Key]     
        [Column(Order = 1)]
        [Required]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

    }
}
