namespace exercicios.repeticao;

public class ExercicioFor
{
    public static void Main()
    {
        //SumNumbers();
        // new CalculaDivisores();
        //Lines.Leitor();
        Impares.Leitor();
    }
    public static void SumNumbers()
    {
        Console.Write("Quandos números inteiros você vai digitar? ");
        int totalNumber = Int32.Parse(Console.ReadLine());
        List<int> numbers = new();
        int sum = 0;

        for (int i = 1; i <= totalNumber; i++)
        {
            Console.Write("Digite o #{0}: ", i);
            int n = Int32.Parse(Console.ReadLine());
            numbers.Add(n);
            sum += n;
        }
        Console.WriteLine($"Soma: {sum}");
    }
}