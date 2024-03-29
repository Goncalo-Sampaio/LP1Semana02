﻿using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Showing the user the min and max value of each type
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);
            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);
            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);
            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);
            Console.WriteLine(char.MaxValue);
            Console.WriteLine(char.MinValue);
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);
            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);
            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);

            //Showing the user special values
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.PositiveInfinity/double.PositiveInfinity);
            Console.WriteLine(float.NaN);

            //Showing overflow in uint to the user
            uint i = ushort.MaxValue;
            Console.WriteLine((ushort) (i + 1));

            //Showing 2 types of float overflow to the user
            Console.WriteLine(2 * float.MaxValue);
            Console.WriteLine(float.MaxValue + 1);

            //Showing float underflow result to the user
            float f1, f2;
            f1 = f2 = 1000.0f;
            Console.WriteLine(f1 == f2 + 0.00003f);
        }
    }
}
