namespace MethodsV4;

public partial class Program
{
    public class NumberHandler
    {
        public void NumberCrunch(int first, int second)
        {
            //The first input printed out.
            Console.WriteLine("The first number equals: " + first);
            
            //The rubric requests I do math with the first input, but it's a void method so...
            first = first + 2;
            
            //As per the instructor, here is the output of the operation:
            Console.WriteLine("First number post math: " + first);
            
            Console.WriteLine("I presume you want me to display the second number ("+second+") to the console?");
            
        }
    }
}