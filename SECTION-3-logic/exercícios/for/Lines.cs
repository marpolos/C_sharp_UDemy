namespace exercicios.repeticao;
static class Lines
{
    private static int Numero { get; set; }
    public static void Leitor()
    {
        Console.Write("Digite o número de linhas desejado: ");
        Numero = Int32.Parse(Console.ReadLine());

        for (int i = 1; i <= Numero; i ++)
        {
            Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
        }
    }

}