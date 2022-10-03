using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /* Fazer método que recebe um vetor de número inteiros e retorna a soma dos
        números impares. */
        static void Main(string[] args)
        {
            int[] v = { 102, 57, 78, 23, 39 };
            int[] impares = new int[4];

            for (int i = 0; i < 5; i++)
            {
                if (v[i] % 2 == 1)
                {
                    impares[i] = v[i];
                }
            }
            //Array.Sort(v);
            //Console.WriteLine("O Menor numero é: ");
            //Console.WriteLine(v[0]);
        }

        public static int Vetor()
        {
            return;
        }

    }
}
