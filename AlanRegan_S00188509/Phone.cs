using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlanRegan_S00188509
{
    public class Phone
    {
        // Props

        public int PhoneID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone(int _PhoneID, string _Name, int _Price, string _OperatingSystem, string _OS_Image, string _PhoneImage)
        {
            PhoneID = _PhoneID;
            Name = _Name;
            Price = _Price;
            OperatingSystem = _OperatingSystem;
            OS_Image = _OS_Image;
            Phone_Image = _PhoneImage;
        }

        // Methods

        public void IncreasePrice(decimal amount)
        {
            Price = Price + (Price * amount);
        }

        
    }

    public class PhoneData : DbContext
    {
        public PhoneData() : base("MyPhoneData") { }
        public DbSet<Phone> PhoneDetails { get; set; }


    }
}
