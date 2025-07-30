using System;
//my variables
decimal hourlyRate1 = 0.00m;
decimal hourlyRate2 = 0.00m;
double hoursWorked1 = 0.0;
double hoursWorked2 = 0.0;
decimal annualSal1 = 0.0m;
decimal annualSal2 = 0.0m;

//Intro
Console.WriteLine("Anonymous Income Comparison Program");

//Gather data
Console.WriteLine("Person 1 hourly rate as numbers only.");
hourlyRate1 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Person 1 hours worked per week as numbers only.");
hoursWorked1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Person 2 hourly rate as numbers only.");
hourlyRate2 = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Person 1 hours worked per week as numbers only.");
hoursWorked2 = Convert.ToDouble(Console.ReadLine());

//Compute salaries (assuming 52 paid weeks a year)
annualSal1 = hourlyRate1 * (decimal)hoursWorked1 * (decimal)52.00;
annualSal2 = hourlyRate2 * (decimal)hoursWorked2 * (decimal)52.00;
Console.WriteLine("Annual salary for Person 1: "+ annualSal1.ToString("0.00"));
Console.WriteLine("Annual salary for Person 2: " + annualSal2.ToString("0.00"));

//Conclude with comparison between person 1 and 2
Console.WriteLine("Does person 1 make more money than person 2?");
if (annualSal1 > annualSal2)
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}