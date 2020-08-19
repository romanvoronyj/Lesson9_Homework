using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_HW
{
    class Adress
    {
        public int index { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int house { get; set; }
        public int apartment { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Adress myAdress = new Adress();
            myAdress.index = 79000;
            myAdress.country = "Ukraine";
            myAdress.city = "Lviv";
            myAdress.street = "Shevchenka str.";
            myAdress.house = 23;
            myAdress.apartment = 42;

            Console.WriteLine("{0}/{1}\n{2}\n{3}\n{4}\n{5}", myAdress.house,myAdress.apartment,myAdress.street,myAdress.city,myAdress.country,myAdress.index);
            Console.ReadKey();
        }
    }
}
