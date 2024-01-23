namespace IndividualProject.People;

public class Person
{
    private string firstName;
    private string lastName;
    private int id;


    public string FirstName
    {
        get { return firstName; }
        set
        {
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            lastName = value;
        }
    }

    public int Id
    {
        get { return id; }
        set
        {
            id = value;
        }
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public Person(string firstName, string lastName, int id)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
    }

    public Person()
    {

    }
}