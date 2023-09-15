using System.Globalization;

namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            double C, F;
            char resposta;

            do
            {
                Console.WriteLine("Digite a temperatura em Celsius: ");
                C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                F = 9.0 * C / 5.0 + 32.0;
                Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1", CultureInfo.InvariantCulture));
                Console.WriteLine("Deseja repetir? (s/n)");
                resposta = char.Parse(Console.ReadLine());

            } while (resposta == 's');

        }
    }
}