using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPrimo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1;

            Console.WriteLine("Digite um número:");

            var num1 = Convert.ToInt32(Console.ReadLine());
            if (num1 <= 1)
            {
                Console.WriteLine($"{num1} não é um número primo");
                Console.ReadKey();
            }
            else
            {
                for (int a = 2; a <= num1 / 2; a++)
                {
                    if (num1 % a == 0)
                    {
                        Console.WriteLine($"{num1} não é um número primo");
                        return;
                    }

                }
                Console.WriteLine($"{num1} é um número primo");
                Console.ReadKey();
            }
        }
    }
}
