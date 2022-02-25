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
            for(int i = 0; i < M; i++)
            {
                int nowx = i, nowy = 0, value = mat[i, 0];
                while(inside(nowx+1, nowy+1, M, N))
                {
                    nowx++;
                    nowy++;
                    if(mat[nowx,nowy] != value) isTeo = false;
                }
            }
            for(int i = 0; i < N; i++)
            {
                int nowx = 0, nowy = i, value = mat[0, i];
                while (inside(nowx + 1, nowy + 1, M, N))
                {
                    nowx++;
                    nowy++;
                    if (mat[nowx, nowy] != value) isTeo = false;
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