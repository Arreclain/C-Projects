using System;

namespace Page226;

//Hey, look!  A static class.  Fulfills #6.
public static class LazyWrite
{
    public static void Print(string msg)
    {
        Console.WriteLine("Your result is " + msg);
    }
}