using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using static System.Console;


namespace WeekdayChecker
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Can you name the current day of the week? \nPlease write the name of a day like so: \n Example \n No punctuation, please.");
            try
            {

                Weekdays input = (Weekdays)Enum.Parse(typeof(Weekdays),ReadLine());
                Weekdays currentDay = (Weekdays)DateTime.Today.DayOfWeek;
                
                if(input == currentDay)
                {
                    WriteLine($"Correct.  The day of the week is {input}.");
                }
                else
                {
                    WriteLine($"No, today is {DateTime.Today.DayOfWeek}");
                }
            }
            catch (Exception)
            {
               WriteLine( "Please enter an actual day of the week.");

            }
        }
    }
}

