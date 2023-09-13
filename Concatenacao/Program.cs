using System;
using System.Globalization;

namespace SAIDADEDADOS
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;
            Console.WriteLine(x);

            Console.WriteLine("RESULTADO = " + x);
            Console.WriteLine("O valor do troco é " + x + " reais");
            Console.WriteLine("O valor do troco é  " + x.ToString("F2") + " reais");
        }
    }
}