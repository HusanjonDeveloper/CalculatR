using System;
namespace CalculatR.classes
{
    public class Securty
    {
        public void checkedPassword()
        {
            string Password = "";

            do
            {
                System.Console.WriteLine("Enter Password");
                Password = Console.ReadLine();
                Console.Clear();
            } while (Password != "0");


        }
    }
}