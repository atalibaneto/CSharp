using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Numero1 = 9;
            int Numero2 = 10;
            int Numero3 = 21;
            int result = (Numero1 + Numero2) - 6 * Numero3 + (12 * 4) / 3 + 112;
            Console.WriteLine($"O quociente inteiro da divisão é: {result}\n");

            int RNumero1 = 9;
            int RNumero2 = 10;
            int RNumero3 = 21;
            int Rresult = (RNumero1 + RNumero2) - 6 * RNumero3 + (12 * 4) % 3 + 112;
            Console.WriteLine($"O resto inteiro da divisão é: {Rresult}\n");

            Console.WriteLine("==== Operações com Inteiros ====");
            int INumero1 = 9;
            int INumero2 = 10;
            int INumero3 = 91;
            int Iresult = (INumero1 + INumero2) - 6 / INumero3;
            Console.WriteLine($"Resultado da operação utlizando inteiro {Iresult}\n");


            Console.WriteLine("==== Operação com double ====");
            double DoNumero1 = 9;
            double DoNumero2 = 10;
            double DoNumero3 = 91;
            double Doresult = (DoNumero1 + DoNumero2) - 6 / DoNumero3;
            Console.WriteLine($"Resultado da operação utlizando double {Doresult}\n");

            Console.WriteLine("==== Operação com float ====");
            float FNumero1 = 9;
            float FNumero2 = 10;
            float FNumero3 = 91;
            float FResult = (FNumero1 + FNumero2) - 6 / FNumero3;
            Console.WriteLine($"Resultado da operação utilizando float {FResult}\n");

            Console.WriteLine("==== Operação com decimal ====");
            decimal DNumero1 = 9;
            decimal DNumero2 = 10;
            decimal DNumero3 = 91;
            decimal DResult = (DNumero1 + DNumero2) - 6 / DNumero3;
            Console.WriteLine($"Resultado da operação utilizando decimal {DResult}\n");

            int Imin = int.MinValue;
            int Imax = int.MaxValue;
            Console.WriteLine($"O intervalo do tipo inteiro está entre {Imin} e {Imax}");

            double Domin = double.MinValue;
            double Domax = double.MaxValue;
            Console.WriteLine($"O intervalo do tipo double está entre {Domin} e {Domax}");

            float Fmin = float.MinValue;
            float Fmax = float.MaxValue;
            Console.WriteLine($"O intervalo do tipo float está entre {Fmin} e {Fmax}");

            decimal Dmin = decimal.MinValue;
            decimal Dmax = decimal.MaxValue;
            Console.WriteLine($"O intervalo do tipo decimal está entre {Dmin} e {Dmax}\n");

            double raio = 2.50;
            double area = Math.PI * raio * raio;
            Console.WriteLine(area);

            double a = 4;
            double b = 5;
            double c = a * a + b * b;
            double r = Math.Sqrt(c);
            //Convert.ToInt16(r);
            Console.WriteLine(r);

            /*int value = 2;
            for (int power = 0; power <= 32; power++)
                Console.WriteLine($"{value}^{power} = {(long)Math.Pow(value, power):N0} (0x{(long)Math.Pow(value, power):X})\n");*/

            double at7 = Math.Pow(2+8, 2) + 18 * 4 - 5 / 3;
            Console.WriteLine(at7);

            Console.Write("\nDigite o ano: ");
            int ano = int.Parse(Console.ReadLine());

            if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
            {
                Console.WriteLine("{0} é um ano bissexto.", ano);
            }
            else
            {
                Console.WriteLine("{0} não é um ano bissexto.", ano);


            }




                Console.ReadKey();
        }
    }
}
