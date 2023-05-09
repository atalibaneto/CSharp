using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimosArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = new List<int>{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (int i = 0; i <= num.Count; i++)
            {
                foreach (var nums in num)
                {
                    if (nums <= 1)
                    {
                        Console.WriteLine($"O número {num[i]} não é primo");
                    }
                }
            }
                    /*for (int a = 2; a <= num.Count / 2; a++)
                    {
                        if (num.Count % a == 0)
                        {
                        Console.WriteLine($"{num[a]} não é um número primo");
                            return;
                        }
                        else
                        {
                        Console.WriteLine($"{num[a]} é primo");

                        }

                    }*/
                    
                }

            
        
    }
}
