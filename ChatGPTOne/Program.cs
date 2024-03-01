using System;

namespace ChatGPTOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //needed variables
            string question, answer;
            bool exit = false;

            while (exit == false)
            {
                //ask the user what's their question
                Console.Write("What's your question? ");
                question = Console.ReadLine();

                //check if its a know question or if the user wants to quit
                switch (question)
                {
                    case "EXIT":
                        exit = true;
                        answer = "Goodbye!";
                        break;
                    default:
                        answer = "I don't understand your question...";
                        break;
                }

                //showing the answer to the user
                Console.WriteLine(answer);
            }
        }
    }
}
