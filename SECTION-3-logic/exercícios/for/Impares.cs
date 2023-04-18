public static class Impares
{
    static int Numero { get; set; }
    public static void Leitor()
    {
        Console.Write("Digite o número de linhas desejado: ");
        Numero = int.Parse(Console.ReadLine());

        for (int i = 1; i <= Numero; i ++)
        {
        }
    }
}