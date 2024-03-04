using System;

class Calculator
{
    static void Main()
    {
        double num1, num2, result = 0;
        char operation;

        Console.WriteLine("Welcome to Calculator!");
        Console.WriteLine("Enter the number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the action (+, -, *, /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.WriteLine("Enter the next number: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: Cannot divide by zero!");
                    return;
                }
                break;
            default:
                Console.WriteLine("An incorrect action was entered!");
                return;
        }

        Console.WriteLine($"Result: {result}");
    }
}