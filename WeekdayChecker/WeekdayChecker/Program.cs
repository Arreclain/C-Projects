using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;


namespace WeekdayChecker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Can you name a day of the week? \n  We really need one!  Please write the name of a week like so: \n Example \n No punctuation, please.");
            try
            {
                var input = Console.ReadLine();
                foreach (Weekdays day in Enum.GetValues(typeof(Weekdays)))
                {
                    if (day.ToString() == input){
                        Console.WriteLine("Thank you.  That was a valid day of the week.");}
                }
            }
            catch (Exception e)
            {
                string e1 = "Please enter an actual day of the week.";
                throw new ArgumentException(e1);
            }
            
        }
    }
}

