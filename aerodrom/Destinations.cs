using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aerodrom
{
    public class Destinations
    {
        public string DestinationName { get; set; }
        public decimal Distance { get; set; }
        public decimal Price { get; set; }


        public override string ToString()
        {
            return string.Format($"{DestinationName} {Distance}km {Price}EUR");
        }
    }
}
