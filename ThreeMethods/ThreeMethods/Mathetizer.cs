namespace ThreeMethods;

public class Mathetizer
{
        public int SuperAdd(int number)
        {
            return number + number + number;
        }

        public int SuperDecrease(int number)
        {
            Random rand = new Random();
                
            return number - rand.Next(10);
        }
        public int SignFlip(int number)
        {
            return number * -1;
        }
    
}