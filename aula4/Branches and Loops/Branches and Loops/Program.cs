using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Branches_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var soma = 0;
            var texto = "texto string de exemplo";
            Console.WriteLine(texto.Length);
            for (var i =1; i <= 100; i++)
            {
                soma = soma + i;
                Console.WriteLine($"A soma dos números de 1 a 100: {i} --- {soma}");
                //soma = 100;
            }
            Console.ReadKey();
        }
    }
}
