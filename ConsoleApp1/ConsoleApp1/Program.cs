
using System;

class BasicArithmetic
{
    static void Main()
    {
        int num1, num2;

        Console.WriteLine("Enter the first number:");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Addition: {num1 + num2}");
        Console.WriteLine($"Subtraction: {num1 - num2}");
        Console.WriteLine($"Multiplication: {num1 * num2}");

        if (num2 != 0)
        {
            double quotient = (double)num1 / num2;
            Console.WriteLine($"Division: {quotient}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }

        Console.ReadLine();
    }
}
