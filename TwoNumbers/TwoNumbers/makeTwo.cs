namespace TwoNumbers;

public class MakeTwo
{
    public int MakeTwoMethod(int numberOne, int numberTwo = 0)
    {
        //I initialize my variable.  All else fails, it will spit out a -1.  An ill omen to be sure.
        int solution = -1;

        //If they gave me a 0, I take it as a non input.
        if (0 == numberTwo)
        {
            solution = numberOne*3+4;
        }
        
        //Otherwise, I run my code with their two inputs.  This method was called in a try/catch, so it's safe here.
        else
        {
            solution = numberOne * (numberTwo % 7);
        }
        
        return solution;
    }
}