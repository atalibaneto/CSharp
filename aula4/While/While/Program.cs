using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            //Console.WriteLine($"{i} Não é par");
            while (i < 50)
            {
                i++;
                if (i % 2 == 0)
                {
                    Console.WriteLine($"Os Números pares de 1 até 50 são: {i}");
                }
                else
                {
                    Console.WriteLine($"{i} Não é par");
                }
            }
            Console.ReadKey();
        }
    }
}
