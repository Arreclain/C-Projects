namespace _243_Abstract_Class;

//#3  This class inherits from Person.  Employees are people, unless they are ChatGPT.
public class Employee : Person
{
    
    //#4 the SayName class is given form within the employee class.
    public override void SayName()
    {
        Console.WriteLine("Name: "+firstName+" "+lastName+".\n");
    }
}