using System.Globalization;

namespace SAIDADEDADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            double a = 6.0;
            double b = -4.0;
            double c = 5.0;

            double delta = Math.Pow(b, 2.0) - 4 * a * c;

            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("O valor de delta é: " + delta);
            Console.WriteLine("O valor do X1 é: " + x1);
            Console.WriteLine("O valor do X2 é: " + x2);

  
        }
    }
}