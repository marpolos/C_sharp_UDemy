using System;
namespace loop.exercicios;
static class Senha
{
    private static readonly string senha = "123456";

    public static void Leitor()
    {
        Console.WriteLine("------------Leitor de senha ----------------------");
        Console.Write("Senha: ");
        string entry = Console.ReadLine();

        while(entry != senha)
        {
            Console.WriteLine("Senha inválida");
            Console.Write("Senha: ");
            entry = Console.ReadLine();
        }

        Console.WriteLine("Acesso permitido.");
    }


}


