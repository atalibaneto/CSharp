using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace troca_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = 0;
            for(var i = 0; i < 20;i++)
            {
                i = i - 1;
                n = n - 2;
            }
            

            Console.WriteLine(n);

        }
    }
}
