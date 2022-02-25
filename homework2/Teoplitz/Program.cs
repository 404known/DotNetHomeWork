using System;

namespace homework2
{
    class Teoplitz
    {
        static void Main()
        {
            Console.WriteLine("Please input M and N.");
            String inp;
            inp = Console.ReadLine();
            int M = int.Parse(inp);
            inp = Console.ReadLine();
            int N = int.Parse(inp);
            int[,] mat = new int[M,N];
            for (int i = 0; i < M; i++)
            {
                for(int j = 0; j < N; j++)
                {
                    inp = Console.ReadLine();
                    mat[i, j] = int.Parse(inp);
                }
            }
            bool isTeo = true;
            for(int i = 1; i < M; i++)
            {
                for(int j = 1; j < N; j++)
                {
                    if(mat[i, j]  != mat[i-1, j-1])
                    {
                        isTeo = false; break;
                    }
                }
            }
            if (isTeo) Console.WriteLine("It is a Teoplitz.");
            else Console.WriteLine("It is not a Teoplitz.");
        }
        static bool inside(int x, int y, int M, int N)
        {
            if(x < 0 || y < 0) return false;
            if(x >= M || y >= N) return false;
            return true;
        }
    }
}