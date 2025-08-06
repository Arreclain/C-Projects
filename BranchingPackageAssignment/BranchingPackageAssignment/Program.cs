using System;

namespace BranchingPackageAssignment
{
    internal static class Program
    {
        //This method exists to control the flow of data intake and to call other functions to complete other steps.
        //It is the principle acting function.
        private static bool AssessWeight(int weight)
        {
            switch (weight)
            {
                case > 50:
                    Console.WriteLine("The package is too heavy to be shipped via Package Express.  Have a good day.");
                    return true;
                default:
                    return false;
            }
        }
        private static bool AssessDimensions(int height, int width, int length)
        {
            int totalDimensions = height + width + length;
            switch (totalDimensions)
            {
                case > 50:
                    Console.WriteLine("The package is too big to be shipped via Package Express.  Have a good day.");
                    return true;
                default:
                    return false;
            }
        }

        private static decimal CalculatePrice(int weight, int height, int width, int length)
        {
            decimal cost = weight * height * width * length/100;
            return cost;
        }

        private static void AssessPackage()
        {
            int weight = 0;
            int height = 0;
            int width = 0;
            int length = 0;
            decimal total = 0.00m;
            
            //All console lines are being interpreted off of the assignment page as though these were
            //specs asked for by the developer.  I think it is good practice to follow exactly what is needed when
            //working as a team so you deliver compatible code to your teammates.
            Console.WriteLine("Please enter the package weight using digits only:");
            weight = Convert.ToInt16(Console.ReadLine());
            //Checks if package is valid.  If package weight is too high (true), terminates program.
            if (AssessWeight(weight))
            {
                return;
            }
            Console.WriteLine("Please enter the package width using digits only:");
            width = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the package height using digits only:");
            height = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Please enter the package length using digits only:");
            length = Convert.ToInt16(Console.ReadLine());
            if (AssessDimensions(height, width, length))
            {
                return;
            }
            total = CalculatePrice(weight, height, width, length);
            Console.WriteLine("Your estimated total for shipping this package is : $"+ total.ToString("C"));
        }


        //Main lies below.
        public static void Main()
        {
            Console.WriteLine("Welcome to Package Express.  Please follow the instructions below.");
            //Keeping code in main to a minimum, as I was taught eons ago.
            AssessPackage();
        }


    }
}