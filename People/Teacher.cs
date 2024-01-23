using System.Text;
using System.Xml;
using IndividualProject.Course;

namespace IndividualProject.People;

public class Teacher : Person, IProfile
{

    private string specialisedSubject;
    private string yearsOfExperience;

    public string SpecialisedSubject
    {
        get { return specialisedSubject; }
        set
        {
            specialisedSubject = value;
        }
    }

    public Teacher()
    {

    }

    public Teacher(string FirstName, string LastName, Enum SpecialisedSubject, int YearsOfExperience) : base(firstName: FirstName, lastName: LastName)
    {

    }

    public Teacher(int id, string FirstName, string LastName, Enum SpecialisedSubject, int YearsOfExperience) : base(firstName: FirstName, lastName: LastName, id)
    {

        specialisedSubject = SpecialisedSubject.ToString();
        yearsOfExperience = YearsOfExperience.ToString();
    }


    public void profile()
    {
        Console.WriteLine(
            $"Hello, my name is {FirstName} {LastName} and I have been teaching {specialisedSubject} for {yearsOfExperience} years");
    }

    public void profile(string firstName, string lastName, string specialisedSubject, string yearsOfExperience)
    {
        Console.WriteLine(
            $"Hello, my name is {firstName} {lastName} and I have been teaching {specialisedSubject} for {yearsOfExperience} years");
    }


    public void getTeachersList()
    {

        List<Teacher> teachers = new List<Teacher>();
        teachers.Add(new Teacher(1, "Kelly", "Reys", Subjects.Engineering, 15));
        teachers.Add(new Teacher(2, "Mike", "Lee", Subjects.Mathematics, 2));
        teachers.Add(new Teacher(3, "Nella", "Laura", Subjects.Photography, 4));
        teachers.Add(new Teacher(4, "Benny", "Jacqui", Subjects.History, 12));
        teachers.Add(new Teacher(4, "Hoval", "Anderson", Subjects.History, 2));
        teachers.Add(new Teacher(4, "Epo", "Vine", Subjects.Mathematics, 4));

        List<Teacher> MathTeachers = new List<Teacher>();
        List<Teacher> EngineeringTeachers = new List<Teacher>();
        List<Teacher> PhotographyTeachers = new List<Teacher>();
        List<Teacher> HistoryTeachers = new List<Teacher>();

        for (int i = 0; i < teachers.Count; i++)
        {
            if (teachers[i].specialisedSubject == Subjects.Mathematics.ToString())
            {
                MathTeachers.Add(teachers[i]);

            }
            else if (teachers[i].specialisedSubject == Subjects.History.ToString())
            {
                HistoryTeachers.Add(teachers[i]);

            }
            else if (teachers[i].specialisedSubject == Subjects.Engineering.ToString())
            {
                EngineeringTeachers.Add(teachers[i]);
            }
            else
            {
                PhotographyTeachers.Add(teachers[i]);
            }
        }

        Console.WriteLine("Please select make a selection: \n1:List all Teachers \n2:List Engineering Teachers \n3:List History Teachers \n4:List Mathematics Teachers \n5:List Photography Teachers");
        string userSelection = Console.ReadLine();
        Console.WriteLine("");

        switch (userSelection)
        {
            case "1":
                foreach (var teacher in teachers)
                {
                    Console.WriteLine($"Name: {teacher.FirstName} {teacher.LastName}, Specialised Subject: {teacher.specialisedSubject}, Number of Years Teaching: {teacher.yearsOfExperience} years");
                }
                break;
            case "2":
                foreach (var teacher in EngineeringTeachers)
                {
                    Console.WriteLine($"Name: {teacher.FirstName} {teacher.LastName}, Specialised Subject: {teacher.specialisedSubject}, Number of Years Teaching: {teacher.yearsOfExperience} years");
                }
                break;
            case "3":
                foreach (var teacher in HistoryTeachers)
                {
                    Console.WriteLine($"Name: {teacher.FirstName} {teacher.LastName}, Specialised Subject: {teacher.specialisedSubject}, Number of Years Teaching: {teacher.yearsOfExperience} years");
                }
                break;
            case "4":
                foreach (var teacher in MathTeachers)
                {
                    Console.WriteLine($"Name: {teacher.FirstName} {teacher.LastName}, Specialised Subject: {teacher.specialisedSubject}, Number of Years Teaching: {teacher.yearsOfExperience} years");
                }
                break;
            case "5":
                foreach (var teacher in PhotographyTeachers)
                {
                    Console.WriteLine($"Name: {teacher.FirstName} {teacher.LastName}, Specialised Subject: {teacher.specialisedSubject}, Number of Years Teaching: {teacher.yearsOfExperience} years");
                }
                break;
            default:
                Console.WriteLine("Invalid Selection. Please try again");
                break;
        }

    }







}
