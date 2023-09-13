using System.Globalization;

namespace SAIDADEDADOS
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine("Nome :" + nome);
            Console.WriteLine("Sexo: " + sexo);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Altura: "  + altura.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}