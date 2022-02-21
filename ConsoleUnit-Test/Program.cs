using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryTest;

namespace ConsoleUnit_Test
{
    class Program
    {
        static void Main()
        {
            Class1 class1 = new Class1();
            Console.Write("Введите пароль:");
            string password = Console.ReadLine();
            if (class1.GetPassword(password)) 
            Console.WriteLine("Корректный пароль");
            else
                Console.WriteLine("Некорректный пароль");
            Console.Write("Введите email:");
            string email = Console.ReadLine();
            if (class1.GetEmail(email))
                Console.WriteLine("Корректный email");
            else
                Console.WriteLine("Некорректный email");
            Console.ReadKey();
        }
    }
}
