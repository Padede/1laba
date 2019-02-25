using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1laba
{

    class Address
    {
        private string city;
        public string City { get; set; }
        private string street;
        public string Street { get; set; }
        private int home_number;
        public int Home_number { get; set; }

        public void print()
        {
            Console.WriteLine("Город:" + city + ", " + "Улица:" + street + ", " + "Номер дома:" + home_number);
        }

        public void setting()
        {
            Console.WriteLine("Введите город");
            city = Console.ReadLine();
            Console.WriteLine("Введите улицу");
            street = Console.ReadLine();
            Console.WriteLine("Введите номер дома");
            home_number = int.Parse(Console.ReadLine());
        }

        public Address()
        {
            city = "Новополоцк";
            street = "Молодежная";
            home_number = 4;
        }

    }

    

    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}
