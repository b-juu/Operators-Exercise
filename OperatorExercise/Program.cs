﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;

            int modulus = a % b;
            int add = a + b;
            int subtract = a - b;
            int divide = a / b;
            int multiply = a * b;


            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");


            }
        }
    }
}
