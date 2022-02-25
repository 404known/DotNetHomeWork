using System;

namespace homework2
{
    class AiShiShaiFa
    {
        static void Main()
        {
            bool[] isPrime = new bool[101];
            for (int i = 1; i < isPrime.Length; i++) isPrime[i] = true;
            isPrime[1] = false;
            for(int i = 2; i <= 50; i++)
            {
                int po = 2 * i;
                while(po <= 100)
                {
                    isPrime[po] = false;
                    po += i;
                }
            }
            for(int i = 1; i < isPrime.Length; i++)
            {
                if (isPrime[i]) Console.WriteLine(i);
            }
        }
    }
}