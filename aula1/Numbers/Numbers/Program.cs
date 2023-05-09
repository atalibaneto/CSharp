using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using é usado para importar bibliotecas
namespace Numbers
//namespace é usado para organizar o código
{
    internal class Program
    {
        static void Main(string[] args)
        // void indica que o método chamado vai retornar alguma coisa
        {
            int numero1 = 9;
            int numero2 = 10;
            int numero3 = 21;
            int result = (numero1 + numero2) - 6 * numero3 + (12 * 4) / 3 + 112;
            // quociente da divisão
            Console.WriteLine($"Resultado inteiro do quociente da divisão: {result}");

            int rnumero1 = 9;
            int rnumero2 = 10;
            int rnumero3 = 21;
            int rresult = (rnumero1 + rnumero2) - 6 * rnumero3 + (12 * 4) % 3 + 112;
            // quociente da divisão
            Console.WriteLine($"Resultado inteiro do resto da divisão: {rresult}");

            double dnumero1 = 9;
            double dnumero2 = 10;
            double dnumero3 = 91;
            double dresult = (dnumero1 + dnumero2) - 6 / dnumero3;
            Console.WriteLine($"Resultado utilizando a variável double: {dresult}");

            float fnumero1 = 9;
            float fnumero2 = 10;
            float fnumero3 = 91;
            float fresult = (fnumero1 + fnumero2) - 6 / fnumero3;
            Console.WriteLine($"Resultado utilizando a variável float: {fresult}");

            //área do círculo
            double raio = 2.50;
            double area = Math.PI * raio * raio;
            Console.WriteLine(area);

            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"O intervalo do tipo decimal está entre {min} e {max}");

            decimal denumero1 = 9;
            decimal denumero2 = 10;
            decimal denumero3 = 91;
            decimal deresult = (denumero1 + denumero2) - 6 / denumero3;
            Console.WriteLine($"Resultado utilizando a variável decimal: {deresult}");

            Console.ReadKey();


        }
    }
}
