using System.Globalization;

namespace SAIDADEDADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.00);

            Console.WriteLine("A Raiz quadrada de " + x + " = " + A);
            Console.WriteLine("A Raiz quadrada de " + y + " = " + B);
            Console.WriteLine("A Raiz quadrada de 25 = " + C);
            
            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.00);
            Console.WriteLine(x + " elevado a " + y + " é " +  A);
            Console.WriteLine(x + " elevado ao quadrado é " + B);
            Console.WriteLine("5 elevado ao quadrado " + C);

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine("Valor absoluto de " + y + " = " + A);
            Console.WriteLine("Valor absoluto de " + z + " = " + B);
            Console.ReadLine();
  
        }
    }
}