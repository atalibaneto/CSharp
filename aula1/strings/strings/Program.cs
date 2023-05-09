using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PrimeiroNome = "John";
            string Sobrenome = "Doe";
            Console.WriteLine($"O nome e sobrenome escrito foi: {PrimeiroNome} e {Sobrenome}");
            Console.WriteLine($"O nome {PrimeiroNome} tem {PrimeiroNome.Length} letras");
            Console.WriteLine($"O nome {Sobrenome} tem {Sobrenome.Length} letras");

            string msg = "      Maravilha      ";
            Console.WriteLine($"[{msg}]");

            string tirabranco = msg.TrimStart();
            Console.WriteLine($"[{tirabranco}]");

            tirabranco = msg.TrimEnd();
            Console.WriteLine($"[{tirabranco}]");

            tirabranco = msg.Trim();
            Console.WriteLine($"[{tirabranco}]\n");

            string egg = "Quem veio primeiro, o ovo ou a galinha?\n";
            Console.WriteLine(egg);

            egg = egg.Replace("galinha", "cloaca");
            Console.WriteLine(egg);

            Console.WriteLine(egg.ToUpper());
            Console.WriteLine(egg.ToLower());

            string letraMusica = "Eu sou apenas um rapaz latino-americano\r\nSem dinheiro no banco sem parentes importantes\r\nE vindo do interior";
            Console.WriteLine($"{letraMusica}\n");
            Console.WriteLine(letraMusica.Contains("dinheiro"));
            Console.WriteLine(letraMusica.Contains("capital"));


            Console.ReadKey();
        }
    }
}
