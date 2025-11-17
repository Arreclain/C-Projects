namespace _243_Abstract_Class;

//#3  This class inherits from Person.  Employees are people, unless they are ChatGPT.
public class Employee<T> : Person, IQuittable
{
    //I needed to create an id for this assigment, so I do, as well as a get and set.
    private int Id {get; set;}

    private List<T> Things = new List<T>();
    
    public int GetId(Employee<T> e1) {return Id;}
    public void SetId(int x) => this.Id = x;
    
    //#4 the SayName class is given form within the employee class.
    public override void SayName()
    {
        Console.WriteLine("Name: "+FirstName+" "+LastName+".\n");
    }

    public void Quit()
    {
        Console.WriteLine("You have quit your current job.");
    }

    public void setThings(List<T> things)
    {
        this.Things = things;
    }

    public List<T> getThings()
    {
        return Things;
    }

    // Now for Operators Submission Assigment page 255 stuff.
    
    //I overload the ==.  This could be smoother code, but it will work.
    public static bool operator ==(Employee<T> e1, Employee<T> e2)
    {
        bool isEqual = false;
        if (e1.Id == e2.Id) isEqual = true;
        return isEqual;
    }

    //My IDE really wanted one for != afterward, so I indulged it.
    public static bool operator !=(Employee<T> e1, Employee<T> e2)
    {
        bool isEqual = false;
        if (e1.Id != e2.Id) isEqual = true;
        return isEqual;
    }
}