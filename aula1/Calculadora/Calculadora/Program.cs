using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual operação deseja fazer");
            Console.WriteLine("1- Adição");
            Console.WriteLine("2- Subtração");
            Console.WriteLine("3- Multiplicação");
            Console.WriteLine("4- Divisão\n");

        
            int operacao = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro número: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número");
            int numero2 = int.Parse(Console.ReadLine());

            

            switch (operacao)
            {
                case 1:
                    {
                        double Adicao = numero1 + numero2;
                        Console.WriteLine(Adicao);
                        break;
                    }
                case 2:
                    {
                        double Subtracao = numero1 - numero2;
                        Console.WriteLine(Subtracao);
                        break;
                    }
                case 3:
                    {
                        double Multiplacacao = numero1 * numero2;
                        Console.WriteLine(Multiplacacao);
                        break;
                    }
                case 4:
                    {
                        double Divisao = numero1 / numero2;
                        Console.WriteLine(Divisao);
                        break;
                    }
                default:
                    Console.WriteLine("Número inválido, digite outro número");
                    break;
            }
            
            
            Console.ReadKey();


        }
    }
}
