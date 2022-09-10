using System;
using System.Globalization;

namespace curso
{
    class Globalization
    {
        public void Convertion()
        {
            int x;
            char y;
            double z;

            x = int.Parse(Console.ReadLine());
            y = char.Parse(Console.ReadLine());
            z = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
        }
    }
}
