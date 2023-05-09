using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Marcos", "Victor", "Gabriela", "Gabriel", "Julia", "Pedro" };
            names.Add("Ataliba");
            names.Add("Luciana");
            names.Add("Débora");
            names.Remove("Ataliba");

            //Console.WriteLine(names[7]);
            foreach (var name in names)
            {
                Console.WriteLine($"Lista de Nomes: {name.ToUpper()}!");
            }

            var indice = names.IndexOf("Asdrubal");
            Console.WriteLine($"A Asdrubal tem índice {indice}");
            /*var r = new Random();
            for (int i = 0; i < names.Count; i++)
            {
                r.Next(6);
                Console.WriteLine(r);
                Console.WriteLine($"Lista de Nomes da TI32: {names[i].ToLower()}!");
            }*/

            Console.ReadKey();
        }
        
    }
}
