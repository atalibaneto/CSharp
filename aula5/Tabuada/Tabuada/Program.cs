using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Numeros = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
            for (int j = 2; j <= 10; j++)
            {
                Console.WriteLine($"==== Tabuada do {Numeros[j]} ====");
                for (int i = 0; i < Numeros.Count; i++)
                {
                    Console.WriteLine($"{Numeros[j]} x {Numeros[i]} = {Numeros[j] * Numeros[i]}");               
                }
            }
        }
    }
}
