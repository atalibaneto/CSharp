using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo1aula
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double numero = int.Parse(Console.ReadLine());
            //double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("O numero digitado é: " + numero);
            Console.WriteLine(String.Format("O numero digitado é: {0}",numero));
            Console.WriteLine($"O número digitado é: {numero}");
            Console.ReadKey();



        }
    }
}
