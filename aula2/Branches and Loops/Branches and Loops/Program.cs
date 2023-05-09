using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branches_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Calcular a soma dos númeors inteiros
             de 1 até 20 que são divisíveis por 3*/
            int sum = 0;
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine($"A soma dos números divisíveis por 3 é: {sum}");
            Console.ReadKey();
        }
    }
}
