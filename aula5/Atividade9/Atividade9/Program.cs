using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número");
            var numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            var numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número");
            var numero3 = int.Parse(Console.ReadLine());
            if (numero1 + numero2 + numero3 > 10) 
            {
                Console.WriteLine("A soma dos números é maior que 10");
            }
            else
            {
                Console.WriteLine("A soma dos números é menor que 10");
            }
        }
    }
}
