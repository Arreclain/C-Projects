using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using static System.Console;


namespace WeekdayChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WriteLine("Can you name a day of the week? \n  We really need one!  Please write the name of a week like so: \n Example \n No punctuation, please.");
            
            try
            {
                Enum.TryParse(ReadLine(),false, out Weekdays input);
                WriteLine($"The day of the week is {input}");
               
            }
            catch
            {
               WriteLine( "Please enter an actual day of the week.");
  
            }
            
        }
    }
}

