    //Long ago, I was taught to put my variables at the top.
using System;
namespace DailyReport{    
    class Program {
        //This is an attempt at checking my inputs.  I can add code to convert things to different types.
        static string assignString(string input)
        {
            if (input == null || input == "")
            {
                Console.WriteLine("You must enter a string");
                return "Invalid data type.";
            }
            else
            {
                return input;
                //Console.WriteLine(saveLocation);
            }
        }

        static bool ToBoolean(string input)
        {
            if (input == "true") return true;
            if (input == "false") return false;
            else return false;
        }
        static void Main(string[] args){
string name = "no name given";
string courseName = "no course name given";
int pageNumber = 0;
string boolInput = "false";
bool needHelp = false;
string positives = "Nothing";
string feedback = "Nothing";
int hoursStudied = 0;
string tempString = "string";


//This is where the body of the program lurks.
//Intro
Console.WriteLine("The Tech Academy");
Console.WriteLine("Student Daily Report");

//Inquiries
Console.WriteLine("What is your name?");
tempString = Console.ReadLine();
name = assignString(tempString);

Console.WriteLine("What course are you on?");
tempString = Console.ReadLine();
courseName = assignString(tempString);

Console.WriteLine("What page number?");
if (int.TryParse(Console.ReadLine(), out var tempInt))
{
    pageNumber = tempInt;
}
else
{
    Console.WriteLine("That wasn't a number");
}
Console.WriteLine("Do you need help with anything?  Please answer \"true\" or \"false.\"");
needHelp = ToBoolean(Console.ReadLine());

Console.WriteLine("Were there any positive experiences you'd like to share?");
positives = Console.ReadLine();

Console.WriteLine("This there any other feedback you'd like to provide?");
feedback = Console.ReadLine();

Console.WriteLine("How many hours did you study? Please type a number using only digits.");
hoursStudied = Convert.ToInt32(Console.ReadLine());

//Conclusion
Console.WriteLine("Thank you for your answers.  An instructor will respond to this shortly.  Have a great day!");
        }
        }
}