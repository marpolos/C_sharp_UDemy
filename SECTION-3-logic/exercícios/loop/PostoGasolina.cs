namespace loop.exercicios;

class PostoGasolina
{
    public Dictionary<int, string> combustiveis = new()
    {
        {1, "Álcool"},
        {2, "Gasolina"},
        {3, "Diesel"},
        {4, "Fim"},
    };

    public int Alcool = 0;
    public int Gasolina = 0;
    public int Diesel = 0;

    public PostoGasolina(){
        Console.WriteLine("------------Posto de Gasolina -------------------");
        Clientes();
        Fim();
    }

    public void Clientes()
    {
        Message();
        int valor = Int32.Parse(Console.ReadLine());
        while (valor < 4 && valor > 0)
        {
            switch(valor)
            {
                case 1: 
                    Alcool += 1;
                    break;
                case 2:
                    Gasolina += 1;
                    break;
                case 3:
                    Diesel += 1;
                    break;
                default: break;
            }
            Console.WriteLine("---------------------------");
            Message();
            valor = Int32.Parse(Console.ReadLine());
        }
    }

    public void Message()
    {
        Console.WriteLine("Qual o combustível favorito: ");

        foreach (KeyValuePair<int, string> element in combustiveis)
        {
            Console.WriteLine($"{element.Key} - {element.Value}");
        }
    }

    public void Fim()
    {
        Console.WriteLine("Muito obrigada");

        Console.WriteLine($"Gasolina: {Gasolina}");
        Console.WriteLine($"Álcool: {Alcool}");
        Console.WriteLine($"Diesel: {Diesel}");
    }
}