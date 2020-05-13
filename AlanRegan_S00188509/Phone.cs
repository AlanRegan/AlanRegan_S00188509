using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanRegan_S00188509
{
    public class Phone
    {
        // Props

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }

        // Methods

        public void IncreasePrice(decimal amount)
        {
            Price = Price + (Price * amount);
        }
    }
}
