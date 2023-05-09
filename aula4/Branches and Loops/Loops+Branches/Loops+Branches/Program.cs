using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops_Branches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = 0;
            for (var i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)
                {
                    soma = soma + i;
                }
            
            }
            Console.WriteLine($"A soma dos números  pares é: {soma}");
            Console.ReadKey();
        }
    }
}
