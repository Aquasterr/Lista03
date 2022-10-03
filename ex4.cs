using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /* Fazer método que recebe 3 valores e o método retorna o menor dentre eles. */
        static void Main(string[] args)
        {
            double[] v = new double [3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite um Valor: ");
                v[i] = double.Parse(Console.ReadLine());
            }
            Array.Sort(v);
            Console.WriteLine("O Menor numero é: ");
            Console.WriteLine(v[0]);
        }
    }
}
