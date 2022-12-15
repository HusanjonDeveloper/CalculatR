using System;
namespace CalculatR.classes
{
    public class Calculator
    {
        public int FristNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Operation { get; set; }

        public void GetInputs()
        {
            Console.WriteLine("type 1st number: ");
            FristNumber = Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Enter operation (+,-,*,/,%)");
            Operation = Console.ReadLine();

            Console.WriteLine("type 2nd number: ");
            SecondNumber = Convert.ToInt32(Console.ReadLine());
        }
        public bool IsFristNumberPositive()
        {
            return FristNumber >= 0;
        }
        public void ComperInputs()
        {
            if (FristNumber > SecondNumber)
            {
                Console.WriteLine("1st nnumber is greater then 2nd number!");
            }
            else if (FristNumber == SecondNumber)
            {
                Console.WriteLine("1st number is equal to 2nd number! ");
            }
            else
            {
                Console.WriteLine("1st number is less than 2nd number!");
            }
        }
        public string Calculate()
        {
            return Operation switch
            {
                "+" => $"{FristNumber} + {SecondNumber} = {FristNumber + SecondNumber}",
                "-" => $"{FristNumber} - {SecondNumber} = {FristNumber - SecondNumber}",
                "*" => $"{FristNumber} * {SecondNumber} = {FristNumber * SecondNumber}",
                "/" => $"{FristNumber} / {SecondNumber} = {FristNumber / SecondNumber}",
                "%" => $"{FristNumber} % {SecondNumber} = {FristNumber % SecondNumber}",
                _ => "Operation Not Found"
            };
        }
    }
}