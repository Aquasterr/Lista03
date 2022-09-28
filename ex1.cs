using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /* Faça um programa que leia um vetor de 10 posições e verifique se existem valores
    iguais e os escreva na tela.
     */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int[] v = new int [10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um numero: \n");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Numeros Repetidos: ");
            for (int i = 0; i < 10; i++)
            {
                for (int x = i + 1; x < 10; x++)
                {
                    if (v[x] == v[i])
                    {
                        int repetido = v[i];
                        Console.WriteLine(repetido);
                    }
                }
            }
        }
    }
}
