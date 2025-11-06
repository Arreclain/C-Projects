using System;

namespace _243_Abstract_Class{

    //#1  Make abstract class named PERSON
public abstract class Person
{
    //#1 also give it string properties of 
    public string firstName;
    public string lastName;

    //#2, An abstract method named SayName, as requested.
    public abstract void SayName();
}
}