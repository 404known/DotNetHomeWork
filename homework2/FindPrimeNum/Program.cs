using System;

namespace homework2
{
    class FindPrimeNum
    {
        static void Main()
        {
            Console.WriteLine("Please input a number");
            int num;
            String s;
            s = Console.ReadLine();
            num = int.Parse(s);
            for(int i = 2; i <= num; i++)
            {
                if (!isPrimeNum(i))
                {
                    continue;
                }
                while(num % i == 0)
                {
                    Console.WriteLine(i);
                    num /= i;
                }
            }

        }
        static bool isPrimeNum(int num)
        {
            if(num <= 1) return false;
            int half = num / 2;
            for(; half > 1; half --)
            {
                if(num % half == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}