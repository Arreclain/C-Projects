using System;

namespace _233_Methods_and_Objects;

public class Program
{
	public static void Main()
	{
		//As per #4 I instantiate and initialize the Employee 'oregonian'.
		Employee oregonian = new Employee();
		//Also as per #4, they are named accordingly.
		oregonian.FirstName = "Sample";
		oregonian.LastName = "Student";
		
		//As per #5, I call SayName() on the Employee object 'oregonian'.
		oregonian.SayName();
	}
}