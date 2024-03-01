using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks the user to input heigh and radius and parses them into float
            Console.Write("Please insert the cylinder's height: ");
            string heightInput = Console.ReadLine();
            float height = float.Parse(heightInput);

            Console.Write("Please insert the cylinder's radius: ");
            string radiusInput = Console.ReadLine();
            float radius = float.Parse(radiusInput);

            //Calculate volume and surface area
            float volume = MathF.PI * MathF.Pow(radius, 2) * height;
            float surface = 2 * MathF.PI * radius * (radius * height);
        }
    }
}
