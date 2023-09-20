namespace Name
{
    class Program
    {
        public static void Main(string[] args)
        {
            int M, N;
            int[,] A;

            string[] element1 = Console.ReadLine().Split(' ');
            M = int.Parse(element1[0]);
            N = int.Parse(element1[1]);
            A = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] element = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    A[i, j] = int.Parse(element[j]);
                }
            }

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                   Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}