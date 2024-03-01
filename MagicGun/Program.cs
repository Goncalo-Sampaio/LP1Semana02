using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for number of shots
            Console.Write("Number of shots: ");
            string input = Console.ReadLine();
            int n = int.Parse(input);

            //Loop to print correct message depending on turn number
            for (int i = 1; i <= n; i ++) {
                if (i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine($"{i}: Magic Fire! Electric Fire!");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i}: Magic Fire!");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}: Electric Fire!");
                }
                else
                {
                    Console.WriteLine($"{i}: Normal fire :/");
                }
            }
        }
    }
}
