using System;
namespace WhileDoWhile{
    internal static class Program{
        private static void Main()
        {
            //This is a simple "game" where you give it a number and the program responds to the number given.
            //It will ask for a digit, then iterate until that number is divisible by 3.
            Console.WriteLine("Please give me a single digit?");
            byte number = Convert.ToByte(Console.ReadLine());

            do
            {
                //Here is where it iterates and increments.
                switch (number % 3)
                {
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("Your number is close to what we're looking for! Let's add 1!");
                        number++;
                        break;
                    default:
                        Console.WriteLine("This is not a digit we like. Let's add 1!");
                        number++;
                        break;
                }
            }
            while (number%3 != 0);
            Console.WriteLine("Your number is divisible by 3! We wanted that!");
            
            //In the next area it pretends to ask you if you want to play again then traps you into playing again.
            
            Console.WriteLine("Wow!  That was fun!  Want to play again? y/n");
            Console.WriteLine("y");
            
            //Here, it will ask for a larger number, then increment that number until it is divisible by 5.
            //I am not doing error checking for this, but boy howdy, I really should be.
            
            Console.WriteLine("Excellent!  Give me a two digit whole number! Please?");
            number = Convert.ToByte(Console.ReadLine());
            while (number % 5 != 0)
            {
                Console.WriteLine("Improving number...");
                number++;
            }
            Console.WriteLine("Your new number is "+ number.ToString()+"!  Which is a superior number.");
        }
        
    }
}