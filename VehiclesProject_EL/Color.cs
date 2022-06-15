using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesProject_EL
{
   public class Color
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Car> cars { get; set; }

        public virtual ICollection<Bus> buses { get; set; }

        public virtual ICollection<Boat> boats { get; set; }
    }
}
