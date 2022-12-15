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

        calculator.PrintEvenNumbers();

        calculator.PrintMultipllcationTable();

        Console.ReadKey();

    }
}