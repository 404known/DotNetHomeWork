using System;

namespace homework2
{
    class ArrayOp
    {
        static void Main()
        {
            Console.WriteLine("How many numbers do you want in this Array?");
            String inp = Console.ReadLine();
            int[] Array = new int [int.Parse (inp)];
            for (int i = 0; i < Array.Length; i++)
            {
                inp = Console.ReadLine();
                Array[i] = int.Parse(inp);
            }
            int max = - int.MaxValue, min = int.MaxValue;
            double avarage;
            long sum = 0;
            for(int i = 0; i < Array.Length; i++)
            {
                if(max < Array[i]) max = Array[i];
                if(min > Array[i]) min = Array[i];
                sum += Array[i];
            }
            avarage = sum / Array.Length;
            Console.WriteLine($"The max number is {max}, the min number is {min}, the sum is {sum}, the avarage is {avarage}");
        }
    }
}