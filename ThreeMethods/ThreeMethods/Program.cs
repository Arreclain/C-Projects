using System;

namespace ThreeMethods{


    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                int number = 0;
            Console.WriteLine("Give me a number, and I shall perform three math operations on it!  " +
                              "Would you like to give me a number?");
            try
            {
                number = Convert.ToInt16(Console.ReadLine());
                Mathetizer mathMe = new Mathetizer();
                number = mathMe.SuperAdd(number);
                Console.WriteLine("Your number currently equals: " + number);
                number = mathMe.SuperDecrease(number);
                Console.WriteLine("Your number currently equals: " + number);
                number = mathMe.SignFlip(number);
                Console.WriteLine("Your new number equals: " + number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong.");
            }
                Console.WriteLine("Exiting program...");
            }
        }

        public class  Mathetizer
        {
            
            public int SuperAdd(int number)
            {
                return number + number + number;
            }

            public int SuperDecrease(int number)
            {
                Random rand = new Random();
                
                return number - rand.Next(10);
            }
            public int SignFlip(int number)
            {
                return number * -1;
            }
        }
    }
}