using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of shots: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            for (int i = 1; i <= n; i ++) {
                Console.WriteLine(i);
            }
        }
    }
}
