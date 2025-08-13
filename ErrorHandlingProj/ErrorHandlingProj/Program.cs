using System;

namespace ErrorHandlingProj
{
    internal static class Program
    {

        static void Main()
        { 
            //Generating a list of ints.
            var numberInt = new List<int>();
            for (int i = 0; i < 7; i++)
            {
                numberInt.Add(i*5);
                Console.WriteLine(numberInt[i]);
            }
            
            //Now we get user input and divide numbers from the list by the input.
            int userInput = 1;
            Console.WriteLine("I need a non-zero number to divide thing by.  Can you give me one?");
            try{
                userInput = Convert.ToInt16(Console.ReadLine());
                foreach (int number in numberInt)
                {
                    Console.WriteLine(number / userInput);
                }
            }
            catch (DivideByZeroException)
            {
               Console.WriteLine("You provided me with zero.  So the answers are all undefined.");
            }
            catch (FormatException)
            {
               Console.WriteLine("Hey, dude.  I need a number that is composed of only digits.  Nothing fancy, please.");
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Okay, we have navigated past the try/catch blocks.");
        }
    }
}