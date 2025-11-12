// See https://aka.ms/new-console-template for more information

namespace _243_Abstract_Class;

public class Program
{
    public static void Main()
    {
        //#5  SUMMON THE EMPLOYEE
        //#3 of Polymorphism submission: create an instance of an object that uses the interface.
        Employee e233 = new Employee();
        //#5  NAME HIM Sample Student
        e233.firstName = "Sample";
        e233.lastName = "Student";
        
        //#5 INVOKE HIM!  MAKE HIM SAY HIS NAME!
        e233.SayName();
        //#3 of Polymorphism submission.
        e233.Quit();
    }
}

