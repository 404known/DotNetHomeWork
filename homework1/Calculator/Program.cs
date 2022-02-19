using System; 

namespace homework1
{
    class calculator
    {
        static void Main()
        {
            Console.WriteLine("Please input a integer");
            string s = "";
            s = Console.ReadLine();
            int m = Int32.Parse(s);
            Console.WriteLine("Please input a integer");
            s = Console.ReadLine();
            int n = Int32.Parse(s);
            Console.WriteLine("Please input an operator");
            s = Console.ReadLine();
            if (s == "+") Console.WriteLine(m + n);
            else if (s == "-") Console.WriteLine(m - n);
            else if (s == "*") Console.WriteLine(m * n);
            else if (s == "/") Console.WriteLine(m / n);
            else Console.WriteLine("invalid input");
        }
    }
}