using System;
namespace _6PartAssingment{
    internal static class Program {
        private static void CheckInput(string input)
        {
            string[] secondSpool = new string[4] {"30092","11202","00090","77744"};
            for (int i = 0; i < secondSpool.Length; i++)
            {
                if (secondSpool[i] == input)
                {
                    Console.WriteLine($"{input} located at position "+ i);
                    return;
                }
            }
            Console.WriteLine($"Your input did not occur.");
        }
        
        private static void FindPair()
        {
            string[] fruitArray = new string[12] {"apple", "banana", "cantaloupe", "guava", "fig", "guava", "jackfruit", "lemon", "orange", "pear", "star fruit", "tangerine" };
            Console.WriteLine("We're looking for fruit!  Kindly list a type of fruit?");
            string fruit = Console.ReadLine().ToLower();
            
            for (int i = 0; i < fruitArray.Length; i++)
            {
                if (fruitArray[i] == fruit)
                {
                    Console.WriteLine(fruit+ " found at position " + i);
                }
            }
        }
        private static void FindRepeat()
        {
            string[] fruitArray = new string[12] {"apple", "banana", "cantaloupe", "guava", "fig", "guava", "jackfruit", "lemon", "orange", "pear", "star fruit", "tangerine" };
            
            for (int i = 0; i < fruitArray.Length; i++)
            {
                for (int j = 0; j < fruitArray.Length; j++)
                {
                    if (fruitArray[i] == fruitArray[j] && i != j)
                    {
                        Console.WriteLine("Positions " + i + " and " + j + " both read as " + fruitArray[i]);
                    }
                }
            }
        }  
        
        
        private static void Main()
        {
            string input = "";
            string[] spool = new string[4] {"Alpha","Bravo","Charlie","Delta" };
            Console.WriteLine("Can you give me a string?");
            input = Console.ReadLine();

            for (int i = 0; i < spool.Length; i++)
            {
                spool[i] += input;
                Console.WriteLine(spool[i]);
            }
            //Oh look, an infinite loop!
            //while(){
            //  while();
            //}
            //The only fix for this kind of abomination is to comment it out.  I have no regrets.
            int[] samples = new int[6] {1,4,6,3,5,7};
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    samples[i]++;
                }
                Console.WriteLine(samples[i]);
            }
            Console.WriteLine("I have an array of strings, each of which is 5 digits?  Want to try to guess one?");
            input = Console.ReadLine();
            CheckInput(input);
            FindPair();
            FindRepeat();
        }
    }
}