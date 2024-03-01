using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to input a non-negative number
            Console.Write("Insere número inteiro não-negativo: ");

            //Saves the input in a string variable and parses it into a byte var
            string userInput = Console.ReadLine();
            byte n = byte.Parse(userInput);

            //Shows the user a decrement of n and an increment of n
            Console.WriteLine(--n);
            Console.WriteLine(++n);

            //Shows the user the division of n by 2
            Console.WriteLine(n/2);

            //Shows the user a shift left of n by 3
            Console.WriteLine(n << 3);

            //Shows the user a xor with 5
            Console.WriteLine(n ^ 5);
        }
    }
}
