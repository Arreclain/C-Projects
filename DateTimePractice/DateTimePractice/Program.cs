using System;

using static System.Console;


namespace DateTimePractice
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            //#1, print current date and time to the console.
            Console.WriteLine(DateTime.Now);
            //#2 Asks the user for a number.
            Console.WriteLine("I require a whole number.  No decimal or fraction, please.");
            int number = int.Parse(Console.ReadLine()!);
            //#3, print the predicted time.
            Console.WriteLine("In {0} hours it will be {1}.",number, DateTime.Now.AddHours(number));
    }
    }
}