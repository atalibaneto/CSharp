using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro");
            int numero = int.Parse(Console.ReadLine());
            int result = numero % 2;
                if (result == 0)
            {
                Console.WriteLine($"O número {numero} é par");
            }
                else
            {
                Console.WriteLine($"O número {numero} é impar");
            }
            Console.ReadKey();
        }
    }
}
