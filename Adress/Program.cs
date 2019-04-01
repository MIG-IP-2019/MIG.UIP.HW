using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adress
{
    class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public int House
        {
            get { return house; }
            set { house = value; }
        }

        public int Apartment
        {
            get { return apartment; }
            set { apartment = value; }
        }

        public void ShowAddress()
        {
            Console.WriteLine(index+"  "+country+"  "+city+"  "+street+"  "+house+"  "+apartment);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Address adress = new Address();
            adress.Country = "Ukraine";
            adress.Index = 03001;
            adress.City = "Kuiv";
            adress.Street = "Lucky";
            adress.House = 17;
            adress.Apartment = 18;
            adress.ShowAddress();

            Console.ReadLine();
        }

        
    }

   
}
