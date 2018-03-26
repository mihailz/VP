using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aerodrom
{
    public class Aerodrom
    {
        public string City { get; set; }
        public string Name { get; set; }
        public string Shourtcut { get; set; }
        public List<Destinations> destinations { get; set; }

        public Aerodrom()
        {
            destinations = new List<Destinations>();
        }


        public override string ToString()
        {
            return string.Format($"{Shourtcut} - {Name} {City}");
        }
    }
}
