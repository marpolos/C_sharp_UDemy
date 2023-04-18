namespace exercicios.repeticao;

class CalculaDivisores
{
    public CalculaDivisores()
    {
        Console.WriteLine("------------Calcula Divisores ----------------------");
        Calculo();
    }

    public int Numero { get; set; }
    public int qtdDivisores = 0;

    public void Calculo()
    {
        Console.Write("Digite um número inteiro: ");
        Numero = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= Numero; i++)
        {
            var modulo = Numero%i;
            if (modulo == 0)
            {
                qtdDivisores += 1;
                Console.WriteLine($"número: {Numero}, divisor: {i}");
            }
        }
        Console.WriteLine($"Número total de divisores: {qtdDivisores}");
    }
}