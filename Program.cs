using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CtoF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Temperature converter.");
            
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.WriteLine("Choose your method: ");
            int method = int.Parse(Console.ReadLine());

            while (true)
            {
                switch (method)
                {
                    case 1:
                        CtoF();
                        break;
                    case 2:
                        FtoC();
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }

                Console.ReadKey();
            }


            
        }

        public static void CtoF()
        {
            Console.Write("Enter Celsius Degree: ");
            double celsius = double.Parse(Console.ReadLine());

            double F = (9 / 5) * celsius +32;

            Console.WriteLine(celsius + "to Fahrenheit is " + F);
        }

        public static void FtoC()
        {
            Console.Write("Enter fahrenheit degree: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double C = (5 / 9) * (fahrenheit - 32);
            Console.WriteLine(fahrenheit + " to Celsius is " + C);
        }
    }
}
