using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /* Fazer método que calcule a leitura de uma temperatura medida em graus Celsius e
        faça a conversão em graus Fahrenheit. A fórmula para a conversão das temperaturas é
        F = (9 * C + 160)/5, sendo F a temperatura em Fahrenheit e C em Celsius. */
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a temperatura em Celsius: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine("A temperatura em Fahrenheit é de: ");
            double f = Fahrenheit(c);
            Console.WriteLine(f);

        }

        public static double Fahrenheit(double c)
        {
            double fahren = (9 * c + 160) / 5;
            return fahren;
        }
    }
}
