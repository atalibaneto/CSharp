using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Exemplo: Uma turma escolar com 15 estudantes precisam ser organizados em grupos 5 
             * grupos diferentes para realizarem uma pesquisa escolar. Para evitar brigas o Professor 
             * te pediu para desenvolver uma pequena aplicação que irá separar o estudantes de forma aleatória.
             * Escreva a aplicação.*/
            string[] estudantes = new string[] { "Anderson", "Castro", "Denise",
                                             "Karla", "Katia", "Lazaro",
                                             "Lucas", "Luciana", "Michel",
                                             "Norma", "Priscila", "Rodrigo",
                                             "Sergio", "Stenio", "Toninho" };

            // Para ordenar de forma aleatória precisamos de uma variável auxiliar.
            Random sorteio = new Random();
            for (int i = 0; i < estudantes.Length - 1; i++)
            {
                int j = sorteio.Next(i, estudantes.Length);
                var temp = estudantes[i];
                estudantes[i] = estudantes[j];
                estudantes[j] = temp;
            }

            int x = 0, grupo = 1;
            foreach (string p in estudantes)
            {
                if (x % 3 == 0)
                {
                    Console.WriteLine("\n\nGrupo " + grupo + ":");
                    grupo++;
                }
                Console.WriteLine(" > " + p);
                x++;
            }
        }
    }
}
