using System.Globalization;
using curso;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
System.Console.WriteLine();

string produto1 = "Computador";
string produto2 = "Mesa de escritório";

byte idade = 30;
int codigo = 5290;
char genero = 'M';

double preco1 = 2100.0;
double preco2 = 650.50;
double medida = 53.234567;

System.Console.WriteLine("Produtos:");
System.Console.WriteLine("{0} cujo preço é {1}", produto1, preco1);
System.Console.WriteLine("{0} cujo preço é {1}", produto2, preco2);
System.Console.WriteLine("\n");
System.Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero: {genero}");
System.Console.WriteLine("\n");
System.Console.WriteLine("Medida com oito casas decimais {0:F8}", medida);
System.Console.WriteLine($"Arredondando 3 casas decimais {medida:F3}");
System.Console.WriteLine($"Separador decimal invariante culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
System.Console.WriteLine($"Separador decimal invariante culture: {medida.ToString(CultureInfo.InvariantCulture)}");
