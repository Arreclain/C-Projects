using System;

namespace Page226;

//This is a class with methods that have void returns.  It fulfills #1.
//They also have output parameters, fulfilling #4.
//There are two methods of the same name, but with different inputs.
//You could say HandleInputs was ... overloaded.  (#5)
public class NumberHandler
{
    public void HandleInputs(int value, out int result)
    {
        result = value / 2;
    }
    
    public void HandleInputs( float valueF, out float resultF)
    {
        resultF = valueF/2.0f;
    }

}