namespace BooleanProject1
{
    internal static class Program
    {
        //The method canHasInsurance checks that all 3 args meet specifications
        // then it returns a boolean as true only if all 3 pass.
        private static bool CanHasInsurance(int age, bool dui, int speeding)
        {
            if (age > 15 && !(dui) && (speeding < 4))
            {
                //Age greater than 15, no DUI, no more than 3 recorded instances of speeding.
                return true;
            }
            //No can has insurance.
            return false;
        }
        private static void Main()
        {
            //Getting my variables in order.
            int age = 0;
            bool dui = false;
            int speeding = 0;
            bool insure = false;
            
            //Inquiries.
            Console.WriteLine("What is your age?");
            age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("True or false, 'I have been charged with a DUI.  Please use lowercase letters for 'true' or 'false'.");
            dui = Convert.ToBoolean(Console.ReadLine());
            
            Console.WriteLine("How many speeding tickets have you received?  Please answer using digits only.");
            speeding = Convert.ToInt32(Console.ReadLine());
            
            //Run check.
            insure = CanHasInsurance(age, dui, speeding);
            Console.WriteLine("It is "+insure+" that this company has found you insurable!");
            Console.WriteLine("Have a nice day!");
        }
    }
}