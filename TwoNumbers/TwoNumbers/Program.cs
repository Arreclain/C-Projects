using System;

namespace TwoNumbers
{

    class Program
    {
        static void Main(string[] args)
        {
            //I have my variables stored at the top.
            int numberOne = 0;
            int numberTwo = 0;
            string userInput = "";
            int result = 0;
            MakeTwo makeNumbers = new MakeTwo();
            
            //Prompt to request the first input, our mandatory integer.
            Console.WriteLine("We're going to need at least one number.  Please provide an integer below. : )");
            numberOne = Convert.ToInt16(Console.ReadLine());
            
            //Explicit instructions on how to opt out of giving a second integer, and a request for more info.
            Console.WriteLine(
                "Okay, now, the next number is optional.  If you would like to not provide a number, type an 'N' for no.  Otherwise, please type an integer.");
            //I store the string in userInput at the top of Main.
            userInput = Console.ReadLine();
            
            
            //If they opted out of a second number...
            if (userInput == "N" || userInput == "n")
            {
                Console.WriteLine("Okay, second number was optional.  That's okay.  Processing...");

                result = makeNumbers.MakeTwoMethod(numberOne);
            }
            
            //Okay, we got a non-'N' input.  Let's encase this in a try block.
            else
            {
                try
                {
                    //The code was good.  We got an integer, and can use that.
                    Console.WriteLine("Your number was read as " + userInput + ".  Processing...");
                    numberTwo = Convert.ToInt16(userInput);

                    result = makeNumbers.MakeTwoMethod(numberOne, numberTwo);
                }
                
                //The user didn't follow instructions.  We run away from the weird reply.
                catch (Exception)
                {
                    Console.WriteLine(
                        "Woah there, partner.  We needed an N or an integer.  You spooked my code with that reply.");
                }
            }
            
            //Print results.
            Console.WriteLine("The result of your hard work is "+result+"!  I don't know if that's significant to you?  I'm just some student's code.  Bye!");
        }
    }
}
