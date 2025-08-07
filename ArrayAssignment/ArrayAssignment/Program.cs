// See https://aka.ms/new-console-template for more information
using System;

namespace ArrayAssignment
{
    internal static class Program
    {
        private static void ArrayController()
        {
            // requestNum will hold input values from the user.
            byte requestNum = 0;
            
            //This generates our string array.
            string[] beanArray = ["Great Northern","Soy","Pinto","Lima","Mung","Black","Red","Kidney"];

            //This part asks the user for a number.
            Console.WriteLine("Input a number between 0 and 7 (inclusive) to receive a random type of bean!");
            requestNum = byte.Parse(Console.ReadLine());

            //Checks if the number is within the array and requests a new number if it is not.
            if (requestNum >= beanArray.Length)
            {
                Console.WriteLine("Ooof.  That number is outside of our array!  Let's try again!");
                Console.WriteLine("Remember, we need a number between 0 and 7 (inclusive).  : )");
                while (requestNum >= beanArray.Length)
                {
                    requestNum = byte.Parse(Console.ReadLine());
                }
            }
            //Upon success, rewards the user with bulk dry beans.
            Console.WriteLine("You will receive " + requestNum + " kilo(s) of " + beanArray[requestNum]+ " beans!");
            
            //Generates the second array, the array of integers!
            byte[] numArray = [1,2,3,5,6,10,12,15,20,30];
            
            //Console.WriteLine requesting a number from the user!
            Console.WriteLine("I have a great and terrible array!  It is full of numbers that divide evenly into 60!");
            Console.WriteLine("Please choose a number between 0 and 9.  0 and 9 are also valid!  So it's inclusive!");
            Console.WriteLine("A better way to write the range would be 0 <= x <= 9, where x is the input.");
            Console.WriteLine("Oh gosh, I've gotten to rambling.  Please, send me a number between 0 and 9, including those two!");
            //Let's check that user input, shall we?  Never know what those rascals might be up to!
            requestNum = byte.Parse(Console.ReadLine());
            if (requestNum >= numArray.Length)
            {
                Console.WriteLine("Oh dear.  That number is outside of our array!  Let's try again!");
                Console.WriteLine("Remember, we need a number between 0 and 9 (inclusive).  : )");
                while (requestNum >= numArray.Length)
                {
                    requestNum = byte.Parse(Console.ReadLine());
                }
            }
            //A lot of silliness, and then the input is returned.  This is why I don't normally code at 7:00 am.  My condolences.
            Console.WriteLine("You know, I just realized I could have asked for a singular digit and avoided all that explanation.");
            Console.WriteLine("Silly me....Oh, right!  Your results!");
            Console.WriteLine("With the sacred number " + requestNum + " we conjure forth " + numArray[requestNum] + " from the array!");
            Console.WriteLine("Wooo! Spooooky!");
            
            //Okay!  One more array!  Err...list!  One more list!  Also the first list!  We can do it!
            //W3 Schools had a list of countries, and that sounds fun, so I'll do my own.
            var countryList = new List<string>() {"Ecuador", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Eswatini", "Ethiopia"};
            Console.WriteLine("\n \nDear user of program, \n \tI write to you to let you know I have a list of all the countries whose name starts with E.\nInput a number, and I shall tell you if it is safer to travel to than the USA, according to www.travelsafe-abroad.com.\nYours truly, programmer");
            requestNum = byte.Parse(Console.ReadLine());
            if (requestNum >= countryList.Count)
            {
                Console.WriteLine("Sorry, but that number is outside of our list of countries!  Let's try again!");
                Console.WriteLine("Remember, we need a number between 0 and 7 (inclusive), because 8 countries names start with E and lists start with position 0.");
                while (requestNum >= countryList.Count)
                {
                    requestNum = byte.Parse(Console.ReadLine());
                }
            }

            switch (requestNum)
            {
                //Oh, boy.  The list.  I just thought that E was an uncommon letter and that this list was going to be short.  It was.  But looking at things like this has been a little chilling.
                //Anyway, this block checks the user input and spits out the appropriate line when comparing their safety scores on that website.
                case 0 or 1 or 2 or 4 or 6 or 7:
                    Console.WriteLine(countryList[requestNum] +" is considered less safe than the USA at the current point in time.");
                    break;
                case 3:
                    Console.WriteLine(countryList[requestNum] +" is considered to be about as safe as the USA at this time.  After reading the factors, I am not sure how they reach this conclusion, but they do comment that  there isn't a lot of crime data to work with?");
                    break;
                default:
                    Console.WriteLine("You must have picked 5, or Estonia!  Apparently their crime is pretty low, just have the usual common sense about you.  Oh, and don't use the taxis.  It seems to have a fair number of medieval sites in great condition.");
                    break;
            }
        }
        
        
        
        //Main is below.  Most of the code is kept out of the main.
        private static void Main()
        {
            ArrayController();
        }
    }
}
