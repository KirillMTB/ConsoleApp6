using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Login (обзательно):");
            string us11 = Console.ReadLine();
            Console.WriteLine("Введите Password (обязательно):");
            string us12 = Console.ReadLine();
            Console.WriteLine("Введите Email:");
            string us13 = Console.ReadLine();

            User user1 = new User(us11, us12)
            {
                Email = us13,
            };
            Console.WriteLine($"Hello, {user1.Login} and {user1.Password} and {user1.Email}");
            Console.ReadKey();
            //Home home = new Home()
            //{
            //    x = 10,
            //    y = 20
            //};
            //Point(home);
            //Console.WriteLine($"{home.x} and {home.y}");
            //Console.ReadKey();
            //People people = new People("Bob")
            //{
            //    Age = 25,
            //};

            //People people1 = new People("Sam");
            //{ }
            //Console.WriteLine($"Hello, {people.Name} and {people1.Name} and {people.Age}");
            //Console.ReadKey();
        }

        static void Point(Home point1)
        {
            point1.y -= 5;
        }


    }
}

