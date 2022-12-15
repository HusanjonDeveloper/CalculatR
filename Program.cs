//  CalculatR

using System;
using CalculatR.classes;

class Programm
{
    private static void Main(string[] args)
    {
        Securty securty = new Securty();
        securty.checkedPassword();

        System.Console.WriteLine("type 1st number: ");
        int fristNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter operation (+,-,*,/,%)");
        string operation = Console.ReadLine();

        System.Console.WriteLine("type 2nd number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        String massage =
        !(fristNumber >= 0)
        ? "1st number not positive"
        : "1st number not negative";

        System.Console.WriteLine(massage);

        if (fristNumber > secondNumber)
        {
            System.Console.WriteLine("1st nnumber is greater then 2nd number!");
        }
        else if (fristNumber == secondNumber)
        {
            System.Console.WriteLine("1st number is equal to 2nd number! ");
        }
        else
        {
            System.Console.WriteLine("1st number is less than 2nd number!");
        }
        string result = operation switch
        {
            "+" => $"{fristNumber} + {secondNumber} = {fristNumber + secondNumber}",
            "-" => $"{fristNumber} - {secondNumber} = {fristNumber - secondNumber}",
            "*" => $"{fristNumber} * {secondNumber} = {fristNumber * secondNumber}",
            "/" => $"{fristNumber} / {secondNumber} = {fristNumber / secondNumber}",
            "%" => $"{fristNumber} % {secondNumber} = {fristNumber % secondNumber}",
            _ => "Operation Not Found"
        };
        System.Console.WriteLine(result);

        int counter = 2;
        while (counter < fristNumber)
        {
            System.Console.WriteLine(counter);
            counter += 2;
        }
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                System.Console.WriteLine($"{i} x {j} = {i * j}");
            }
        }
        System.Console.WriteLine("\n");

        Console.ReadKey();

    }
}