//  CalculatR

using System;
using CalculatR.classes;

class Programm
{
    private static void Main(string[] args)
    {
        Securty securty = new Securty();
        Calculator calculator = new Calculator();

        securty.checkedPassword();

        calculator.GetInputs();

        String massage =
        !(calculator.IsFristNumberPositive())
        ? "1st number not positive"
        : "1st number not negative";

        Console.WriteLine(massage);

        calculator.ComperInputs();

        string result = calculator.Calculate();
        System.Console.WriteLine(result);

        int counter = 2;
        while (counter < calculator.FristNumber)
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