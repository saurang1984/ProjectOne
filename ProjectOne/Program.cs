﻿namespace ProjectOne
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // You can instantiate your Calculator class and call methods here, if needed.
            var calculator = new Calculator();
            int sum = calculator.Add(2, 3);
            Console.WriteLine($"Sum of 2 and 3 is: {sum}");

            // updated per issue # 123
            int mul = calculator.Multiply(19, 5);
            Console.WriteLine($"Multiplication of 19 and 5 is: {mul}");


        }
    }
}
