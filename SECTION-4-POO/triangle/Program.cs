using System;
using System.Globalization;
using Pessoa;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;
            x = new Triangle();
            y = new Triangle();

            /* System.Console.WriteLine("Digite os lados do triângulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            System.Console.WriteLine("Digite os lados do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine($"A área do triângulo X é {x.Area()}");
            System.Console.WriteLine($"A área do triângulo Y é {y.Area()}"); */
            Individuo people1, people2;
            people1 = new Individuo();
            System.Console.WriteLine("Digite nome e idade");
            people1.nome = System.Console.ReadLine();
            people1.idade = int.Parse(System.Console.ReadLine());

            people2 = new Individuo();
            System.Console.WriteLine("Digite nome e idade");
            people2.nome = System.Console.ReadLine();
            people2.idade = int.Parse(System.Console.ReadLine());

            if(people1.idade > people2.idade)
            {
                System.Console.WriteLine("Pessoa mais velha " + people1.nome);
            }
            else
            {
                System.Console.WriteLine("Pessoa mais velha " + people2.nome);
            }
        }
    }
}
