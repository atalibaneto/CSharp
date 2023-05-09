using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new string[] { "Victor", "Marcos", "Gabriela", "Gabriel", "Julia", "Pedro" };
            var i = -1;
            
            Random aleatorio = new Random();
            while (i < names.Length)//for (var i = 0; i < names.Length; i++)
            {
                i++;
                int j = aleatorio.Next(i, names.Length);
                
                (names[i], names[j]) = (names[j], names[i]);
                Console.WriteLine(names[j]);
            }
            Console.ReadKey();

        }
    }
}
