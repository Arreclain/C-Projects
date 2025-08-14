using System;

namespace ThreeMethodsV2
{


    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                int number = 0;
                decimal number2 = 0;
                Console.WriteLine("Give me a number, and I shall perform three math operations on it!  " +
                                  "Would you like to give me a number?");
                try
                {
                    number = Convert.ToInt16(Console.ReadLine());
                    MathetizerV2 mathMe = new MathetizerV2();
                    number = mathMe.Doublify(number);
                    Console.WriteLine("Your number currently equals: " + number);
                    //convert number to a decimal.
                    number2 = number;
                    number2 = mathMe.Doublify(number2);
                    Console.WriteLine("Your number currently equals: " + number);
                    Console.WriteLine("Form my next trick, I will read a new string!  Can I have a number, please?");
                    string input = Console.ReadLine();
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

        public class MathetizerV2
        {
            public int Doublify(int a)
            {
                return a + a;
            }

            public decimal Doublify(decimal a)
            {
                return a * 2;
            }

            public int Doublify(string a)
            {
                int data = int.Parse(a);
                data = data * 2 +2;
               return data;
            }
        }

    }
}