using System;

namespace MySum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(args.Length);
            int a = Convert.ToInt32(args[0]);
            int b = Convert.ToInt32(args[1]);
            Console.WriteLine(a + b);
        }
    }
}
