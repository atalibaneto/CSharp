using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort__Search__and_Index_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "José", "Ailton", "Lúcia", "Amanda", "Roberto" };
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            var indice = names.IndexOf("Ailton");

            if (indice == -1)
            {
                Console.WriteLine($"Quando o ítem não é encontrado, IndexOf retorna {indice}");
            }
            else
            {
                Console.WriteLine($"O nome buscado foi: {names[indice]} e está na posição {indice}");
            }
            //Console.WriteLine($"O nome {names[indice]} está na posição {indice}");
            Console.ReadKey();
        }
    }
}
