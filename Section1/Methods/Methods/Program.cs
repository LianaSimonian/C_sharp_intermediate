using System;

namespace Methods
{ 
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var num = int.Parse("abc");
            }
            catch (Exception)
            {
                Console.WriteLine("conversion failed");
            }

           int number;
           var result = int.TryParse("abc", out number);
            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("conversion failed");
            
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add());
            Console.WriteLine(calculator.Add(new int[] { 1, 4, 5, 7, 8 }));
        }
        static void UsePoints() {
            var point = new Point(10, 20);
            try
            {
                point.Move(null);
                Console.WriteLine("Point is at ( {0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("an unexpected error occurred. ");
            }

            point.Move(100, 200);
            Console.WriteLine("Point is at ( {0},{1})", point.X, point.Y);
        }
    }
}
