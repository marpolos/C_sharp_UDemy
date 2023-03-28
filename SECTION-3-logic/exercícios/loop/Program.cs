using System;
using System.Globalization;

namespace loop.exercicios;

public class Loop
{
    public static void Main()
    {
        // MakeRaiz();
        // Senha.Leitor();
        // PlanoCartesiano Plano = new();

        PostoGasolina Posto = new();
    }
    public static void MakeRaiz()
    {
        Console.WriteLine("------------Raiz ----------------------");
        // See https://aka.ms/new-console-template for more information
        Console.Write("Digite um número: ");
        double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        while(x >= 0)
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));

            Console.Write("Digite outro número: ");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        Console.WriteLine("Número negativo.");

    }

    public Loop()
    {
        MakeRaiz();
        Senha.Leitor();
    }

}