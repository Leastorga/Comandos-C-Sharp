using System;
using System.Globalization;

namespace SAIDADEDADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exemplo 1 de Casting
            int a, c;
            double resultado;

            a = 5;
            c = 2;

            resultado = (double)a / c;
            Console.WriteLine(resultado);

            // Exemplo 2
            int xx;
            double yy;
            xx = 5;
            yy = 2 * xx;

            Console.WriteLine(xx);
            Console.WriteLine(yy);

            // Exemplo 3
            double b, B, h, area;
            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b + B) / 2.0 * h;
            Console.WriteLine(area);

            // Exemplo 4 
            int x, y;
            x = 5;
            y = 2 * x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            // Exemplo 5 ( O que não pode ocorrer!!!)
            double aa;
            int bb;

            aa = 5.0;
            bb = a;

            Console.WriteLine(bb);





        }
    }
}