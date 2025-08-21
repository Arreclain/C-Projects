using System;

namespace TwoNumbers
{

    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 0;
            string userInput = "";
            int result = 0;

            Console.WriteLine("We're going to need at least one number.  Please provide an integer below. : )");
            numberOne = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(
                "Okay, now, the next number is optional.  If you would like to not provide a number, type an 'N' for no.  Otherwise, please type an integer.");
            userInput = Console.ReadLine();
            if (userInput == "N" || userInput == "n")
            {
                Console.WriteLine("Okay, second number was optional.  That's okay.  Processing...");

                result = MakeTwo(numberOne);
            }
            else
            {
                try
                {
                    Console.WriteLine("Your number was read as " + userInput + ".  Processing...");
                    numberTwo = Convert.ToInt16(userInput);

                    result = MakeTwo(numberOne, numberTwo);
                }
                catch (Exception)
                {
                    Console.WriteLine(
                        "Woah there, partner.  We needed an N or an integer.  You spooked my code with that reply.");
                }
            }
            Console.WriteLine("The result of your hard work is "+result+"!  I don't know if that's significant to you?  I'm just some student's code.  Bye!");
        }
    }
}
