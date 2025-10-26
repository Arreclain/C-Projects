using System;

namespace MethodsV4
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            //I have instantiated the class.
            NumberHandler hello = new NumberHandler();
            
            
            //I have called the method passing in two numbers.
            //I think I have named each entry?
            hello.NumberCrunch(first: 4, second: 5);
            
            System.Console.WriteLine("Hello!  An instructor would like this to run with user provided numbers." +
                                     "Please provide a non-zero digit.");
            int number1 = Convert.ToInt16(Console.ReadLine());
            System.Console.WriteLine("Hello!  I now require a second number." +
                                     "Please provide a non-zero digit.");
            int number2 = Convert.ToInt16(Console.ReadLine());
            hello.NumberCrunch(first: number1, second: number2);
            
        }
        
        
    }
}


