﻿namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] vet = new string[n];

            for (int i = 0; i < n; i++)
            {
                vet[i] = Console.ReadLine();
            }

            Console.WriteLine("Nomes lidos: ");
            foreach (string elemento in vet)
            {
                Console.WriteLine(elemento);
            }
        }
    }
}