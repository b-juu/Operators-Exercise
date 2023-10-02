namespace OperatorExercise
{
    public class Program
    {




        static void Main(string[] args)
        {


            // Exercise 1


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
            // Exercise 2

            Console.Write("What is the radius of your circle? ");
            var radius = double.Parse(Console.ReadLine());
            Console.Write($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}.");

            //thought experiment

            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine(k);









        }
           //Ex 2
            public static double AreaOfCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
           
        }
    }
}

