using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlanRegan_S00188509;

namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneData db = new PhoneData();

            using (db)
            {

                Phone p1 = new Phone(1, "Samsung S20", 500, "Android", "/images/android.png", "/images/s20.jpg");
                Phone p2 = new Phone(2, "iPhone 11", 600, "IOS", "/images/apple.png", "/images/iphone11.jpg");

                db.PhoneDetails.Add(p1);
                db.PhoneDetails.Add(p2);

                Console.WriteLine("Added phones to database");

                db.SaveChanges();

                Console.WriteLine("Saved Changes");
            }
        }
    }
}
