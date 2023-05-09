using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var fibo = new List<int> { 1, 1 };

            while (fibo.Count < 20) 
            {
                var NumeroAnterior1 = fibo[fibo.Count - 1];
                var NumeroAnterior2 = fibo[fibo.Count - 2];

                fibo.Add(NumeroAnterior1 + NumeroAnterior2);
            }
            foreach (var item in fibo)
            {
                Console.WriteLine(item);
            }
        }
    }
}
