using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("1. Add");
        Console.WriteLine("2. Subtract");
        //Console.WriteLine("3. Multiply");
        //Console.WriteLine("4. Divide");

        var choice = Console.ReadLine();

        Console.Write("Enter first number: ");
        var num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        var num2 = Convert.ToDouble(Console.ReadLine());

        double result;
        switch (choice)
        {
            case "1":
                result = num1 + num2;
                Console.WriteLine($"Result: {result}");
                break;
            case "2":
                result = num1 - num2;
                Console.WriteLine($"Result: {result}");
                break;
            case "3":
                result = num1 * num2;
                Console.WriteLine($"Result: {result}");
                break;
            //case "4":
            //    if (num2 != 0)
            //    {
            //        result = num1 / num2;
            //        Console.WriteLine($"Result: {result}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error! Division by zero.");
            //    }
            //    break;
            default:
                Console.WriteLine("Invalid Input");
                break;
        }

        return;
    }
}