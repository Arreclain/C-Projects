using System;
namespace _233_Methods_and_Objects;

//As per #1, there is a class named Person.
public class Person
{
    //Furthermore, that class has two properties: the two halves of their name.
    public string FirstName;
    public string LastName;

    //As per #2, there is a void method that spits out the name in the required format.
    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}