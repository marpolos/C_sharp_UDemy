namespace loop.exercicios;

class PlanoCartesiano
{
    public PlanoCartesiano()
    {
        Console.WriteLine("------------Plano Cartesiano ----------------------");
        Coordenadas();
    }

    private int _x;
    public int X { get => _x; set => _x = value; }
    private int _y;
    public int Y { get => _y; set => _y = value; }

    private int nulo = 0;

    public void Coordenadas()
    {
        Console.Write("Coordenada x: ");
        X = Int32.Parse(Console.ReadLine());

        Console.Write("Coordenada y: ");
        Y = Int32.Parse(Console.ReadLine());
         while(X != 0 && Y != 0)
        {
            if (X > 0)
            {
                if (Y > 0)
                {
                    Console.WriteLine("Primeiro quadrante");
                }
                else if(Y == 0)
                {
                    Console.WriteLine("Nulo");
                    nulo += 1;
                }
                else{
                    Console.WriteLine("Quarto quadrante");
                }
            }
            else if (X == 0)
            {
                Console.WriteLine("Nulo");
                nulo += 1;
            }
            else
            {
                if (Y > 0)
                {
                    Console.WriteLine("Segundo quadrante");
                }
                else if(Y == 0)
                {
                    Console.WriteLine("Nulo");
                    nulo += 1;
                }
                else{
                    Console.WriteLine("Terceiro quadrante");
                }
            }

            Console.Write("Coordenada x: ");
            X = Int32.Parse(Console.ReadLine());

            Console.Write("Coordenada y: ");
            Y = Int32.Parse(Console.ReadLine());
        }

    }

}