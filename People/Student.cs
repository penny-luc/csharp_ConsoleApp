using IndividualProject.Course;

namespace IndividualProject.People;

public class Student : Person
{
    private string firstChoiceSubject;
    public string FirstChoiceSubject
    {
        get { return firstChoiceSubject; }
        set
        {
            firstChoiceSubject = value;
        }
    }


    public Student()
    {

    }
    public Student(int id, string firstName, string lastName, Enum firstChoiceSubject) : base(firstName, lastName, id)
    {
        this.firstChoiceSubject = firstChoiceSubject.ToString();
    }



    public void preferedStudyChoices(Enum firstChoiceSubject)
    {
        Console.WriteLine($"My first choice would be {firstChoiceSubject}");
    }
    public void preferedStudyChoices(string firstChoiceSubject, string secondChoiceSubject)
    {
        Console.WriteLine($"My first choice would be {firstChoiceSubject}, and my second choice would be {secondChoiceSubject}");
    }

    public void getStudentDetails()
    {

        List<Student> students = new List<Student>();
        students.Add(new Student(1, "Kim", "Jones", Subjects.Engineering));
        students.Add(new Student(2, "Allie", "Nedd", Subjects.History));
        students.Add(new Student(3, "Will", "Chris", Subjects.Photography));
        students.Add(new Student(4, "Robin", "Moore", Subjects.History));
        students.Add(new Student(5, "Toby", "Karmara", Subjects.Engineering));
        students.Add(new Student(6, "Francis", "Jurgen", Subjects.Mathematics));


        foreach (var student in students)
        {
            student.profile();
        }

    }

    public void profile()
    {
        Console.WriteLine($"ID:{Id}\nFull Name: {FirstName} {LastName} \nCourse: {FirstChoiceSubject}");
    }
}