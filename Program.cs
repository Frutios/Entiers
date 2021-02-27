using System;

namespace Entiers
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.MaxValue;
            long y = long.MaxValue;
            short z = short.MaxValue;

            ulong w = (ulong)(x + y + z);
            Console.WriteLine(w);
        }
    }
}
