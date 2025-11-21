namespace EmployeeAppNum2;

public class Employee(string first, string last, short id)
{
    //This is a constructor.
    private string _firstName = first;
    private string _lastName = last;
    private short _id = id;


    //Gets and Sets aplenty!
    public string FirstNameGet()
    {
        return this._firstName;
    }

    public void FirstNameSet(string x)
    {
        this._firstName = x;
    }
    
    public string LastNameGet()
    {
        return this._lastName;
    }

    public void LastNameSet(string x)
    {
        this._lastName = x;
    }
    
    public short IdGet()
    {
        return _id;
    }

    public void IdSet(short x)
    {
        this._id = x;
    }

}