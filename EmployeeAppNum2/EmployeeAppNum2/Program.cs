using System;

namespace EmployeeAppNum2{

    public class Program
    {
        public static void Main(string[] args)
        {

            //Make some employees, with many Joes among them.
            Employee e01 = new Employee("Andre","Lourenco",3);
            Employee e02 = new Employee("Elijah","Houck",4);
            Employee e03 = new Employee("Steve","de Vries",5);
            Employee e04 = new Employee("David","Jaffe",6);
            Employee e05 = new Employee("Jane","Jensen",7);
            Employee e06 = new Employee("Joe","Sample",8);
            Employee e07 = new Employee("Jarek","Kolar",9);
            Employee e08 = new Employee("Soren","Johnson",10);
            Employee e09 = new Employee("Joe","Duplicaate",11);
            Employee e10 = new Employee("Jeff","Minter",12);
            Employee e11 = new Employee("Markus","Persson",13);
            Employee e12 = new Employee("Joe","DROPTABLES",14);
            
            //Add them to a list.
            List<Employee> payroll = new List<Employee>();
            payroll.Add(e01);
            payroll.Add(e02);
            payroll.Add(e03);
            payroll.Add(e04);
            payroll.Add(e05);
            payroll.Add(e06);
            payroll.Add(e07);
            payroll.Add(e08);
            payroll.Add(e09);
            payroll.Add(e10);
            payroll.Add(e11);
            payroll.Add(e12);

            //Foreach is used to iterate through payroll.
            foreach (Employee e in payroll)
            {
                if (e.FirstNameGet() == "Joe")
                {
                    Console.WriteLine(e.FirstNameGet()+" "+e.LastNameGet());
                }
            }
            
            
            //Added so the console is easier to read with human eyes.
            Console.WriteLine("\n");
            
            
            //Now we goe through it with a lambda expression.  First I make a list to hold the results...
            List<Employee> joes;
            
            //Then I populate the list using the lambda expression.
            joes = payroll.FindAll(x => x.FirstNameGet() == "Joe");
            
            //Finally, I print the results.  I use the same format to maintain consistency.
            foreach (Employee e in joes) Console.WriteLine(e.FirstNameGet()+" "+e.LastNameGet());
            
            
            //Added so the console is easier to read with human eyes.            
            Console.WriteLine("\n");
            
            
            //Now I go through the list to find employees with an id value greater than 5.
            //First I make a list to populate.
            List<Employee> idSort;
            //Then I populate the list using a lambda expression.
            idSort = payroll.FindAll(x => x.IdGet() > 5);
            //Then I print it out using a foreach loop.
            foreach (Employee e in idSort) Console.WriteLine(e.FirstNameGet()+" "+e.LastNameGet());
        }
    }
}