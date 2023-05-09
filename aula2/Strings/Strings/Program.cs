using System;


namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PrimeiroNome = "John";
            string Sobrenome = "Doe";
            Console.WriteLine(PrimeiroNome + Sobrenome);
            Console.WriteLine($"O nome informado é {PrimeiroNome} e o sobrenome é {Sobrenome}");
            string ContadorLetras = "Paralelepípedo";
            Console.WriteLine($"A palavra {ContadorLetras} tem {ContadorLetras.Length} letras");

            string msg = "      Maravilha      ";
            Console.WriteLine($"[{msg}]");

            string TiraBranco = msg.Trim();
            Console.WriteLine($"[{TiraBranco}]");

            string TiraBrancoI = msg.TrimStart();
            Console.WriteLine($"[{TiraBrancoI}]");

            string TiraBrancoF = msg.TrimEnd();
            Console.WriteLine($"[{TiraBrancoF}]");

            string egg = "Quem veio primeiro, o ovo ou a galinha?\n";
            Console.WriteLine(egg);

            egg = egg.Replace("galinha", "dinossaura");
            Console.WriteLine($"Aplicando Replace: {egg}\n");
            Console.WriteLine(egg.ToUpper());
            Console.WriteLine(egg.ToLower());

            string LetraMusica = "Eu sou apenas um rapaz latino-americano\r\nSem dinheiro no banco\r\nSem parentes importantes\r\nE vindo do interior";
            Console.WriteLine($"{LetraMusica}\n");
            Console.WriteLine(LetraMusica.Contains("dinheiro"));
            Console.WriteLine(LetraMusica.Contains("rapaz"));
            Console.ReadLine();
        }
    }
}
