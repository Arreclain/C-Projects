using System;

namespace ThreeMethodsV2
{


    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                //Creating my variables.
                int number = 0;
                decimal number2 = 0;
                
                //Initial request for user input.  When read, it is assigned to number.  Console.ReadLine() in try block.
                Console.WriteLine("Give me a number, and I shall perform three math operations on it!  " +
                                  "Would you like to give me a number?");
                try
                {
                    //Tries to store the user input, then calls the overloaded Mathetizer function.
                    number = Convert.ToInt16(Console.ReadLine());
                    Mathetizer mathMe = new Mathetizer();
                    number = mathMe.Doublify(number);
                    //Outputs the result.
                    Console.WriteLine("Your number currently equals: " + number);
                    
                    
                    //convert number to a decimal.
                    number2 = (decimal)number;
                    //Use said decimal to trigger an alternate form of Mathetizer.
                    number2 = mathMe.Doublify(number2);
                    Console.WriteLine("Your number currently equals: " + number2);
                    
                    
                    //Now to set up and trigger the final form of Mathetizer: the form that takes a string.
                    Console.WriteLine("Form my next trick, I will read a new string!  Can I have a number, please?");
                    //I declare a variable down here so that the code is more legible, as per instructor request.
                    string input = Console.ReadLine();
                    //Calls the Mathetizer function on the string.
                    number = mathMe.Doublify(input);
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
    }
}