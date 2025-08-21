namespace TwoNumbers;

public static class MakeTwo
{
    public static int MakeTwo(int numberOne, int numberTwo = 0)
    {
        int solution = -1;

        if (0 == numberTwo)
        {
            solution = numberOne*3+4;
        }
        else
        {
            solution = numberOne * (numberTwo % 7);
        }
        
        return solution;
    }
}