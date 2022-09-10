namespace Program;
public class Program
{
    public static void Main()
    {
        // VendaProdutos();
        // AreaCirculo();
        // Hamburgueria();
        Baskara();
        // Senha();
        // ReadNumber();
    }

    static void VendaProdutos()
    {
        double calculate = 0d;
        string addMore = "s";

        do {
        Console.WriteLine("Digite o código do produto, quantidade vendida e o preço: (cod qtd p)");
        Console.WriteLine("Números decimais devem ser digitados com vírgula (5,3 e não 5.3)");
        string entry = Console.ReadLine();
        string[] entryArray = entry.Split(" ");
        calculate += Convert.ToDouble(entryArray[1]) * Convert.ToDouble(entryArray[2]);
        Console.Write("Deseja adicionar mais itens? (s/n) ");
        addMore = Console.ReadLine();
        }
        while(addMore == "s");

        Console.WriteLine($"O valor da compra é: R${calculate:N2}");
    }

    static void AreaCirculo()
    {
        Console.WriteLine("Digito o tamanho do raio:");
        double raio = Convert.ToDouble(Console.ReadLine());

        double pi = 3.14159f;
        double area = pi * raio * raio;

        Console.WriteLine($"Área é {area:N4}");
    }

    static void Hamburgueria()
    {
        double calculate = 0d;
        string addMore = "s";
        double value = 0;

        do
        {
        Console.WriteLine("Digite o código do produto e a quantidade: (cod qtde)");
        string[] item = Console.ReadLine().Split(" ");

        switch(item[0])
        {
            case "1":
                value = 4.00d;
                break;
            case "2":
                value = 4.50d;
                break;
            case "3":
                value = 5.00d;
                break;
            case "4":
                value = 2.00d;
                break;
            case "5":
                value = 1.5d;
                break;
            default:
                value = 0;
                break;
        }

        calculate += value * Convert.ToDouble(item[1]);

        
        Console.Write("Deseja adicionar mais itens? (s/n) ");
        addMore = Console.ReadLine();
        }
        while(addMore == "s");

        Console.WriteLine($"Valor total: {calculate:N2}");

    }

    static void Baskara()
    {
        Console.WriteLine("Digite a, b e c para calculo das raízes: (a, b, c)");
        string[] valores = Console.ReadLine().Split(", ");
        double a = Convert.ToDouble(valores[0]);
        double b = Convert.ToDouble(valores[1]);
        double c = Convert.ToDouble(valores[2]);

        if(a == 0)
        {
            Console.WriteLine($"Impossível calcular, pois a = {a}");
        }
        else
        {
            double delta = Math.Pow(b, 2) - 4 * a * c;
            if(delta < 0) Console.WriteLine($"Impossível calcular, pois delta = {delta}");
            else
            {
                Console.WriteLine($"delta {delta}");
                double x1 = (- b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"first {- b + Math.Sqrt(delta)}");
                Console.WriteLine(2*a);
                double x2 = (- b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"second {- b - Math.Sqrt(delta)}");
                Console.WriteLine(2*a);
                Console.WriteLine($"As raízes são: x1: {x1} e x2: {x2}");
            }
        }
    }

    static void Senha()
    {
        string senha = "2002";
        string userSenha;
        do
        {
            Console.WriteLine("Digite a senha: ");
            userSenha = Console.ReadLine();
            if (userSenha != senha) Console.WriteLine("Senha Invalida");
            else Console.WriteLine("Acesso Permitido");
        }
        while(userSenha != senha);
    }
    
    static void ReadNumber()
    {
        Console.WriteLine("Digite quantos números quer testar:");
        int qtde = Convert.ToInt32(Console.ReadLine());
        int inInterval = 0;
        int outInterval = 0;

        for (int i = 1; i <= qtde; i ++)
        {
            Console.WriteLine("Insira o número:");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num > 10 && num < 20)
            {
                inInterval += 1;
            }
            else outInterval += 1;
        }

        Console.WriteLine($"in: {inInterval} \n out: {outInterval}");
    }
}
