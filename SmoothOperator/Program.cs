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

            //Shows the user the division of n for 2
            Console.WriteLine(n/2);
        }
    }
}
