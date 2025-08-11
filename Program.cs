using System;

class Program
{
    static void Main()
    {
        double num1, num2, result = 0;
        char operation;

        //Console.WriteLine("ماشین حساب ساده به زبان C#");
        Console.Write("number one: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write(" (+ - * /): ");
        operation = Convert.ToChar(Console.ReadLine());

        Console.Write("number two: ");
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
                    result = num1 / num2;
                else
                {
                    Console.WriteLine("Error: Division by zero is not allowed.\r\n!");
                    return;
                }
                break;
            default:
                Console.WriteLine("Error.Error");
                return;
        }

        Console.WriteLine($"the result: {result}");
        
    }
}

