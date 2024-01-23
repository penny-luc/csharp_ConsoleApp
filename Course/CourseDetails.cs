namespace IndividualProject.Course;

public class CourseDetails
{
    public string CourseName;
    public string GradeEntry;
    public int LengthOfCourse;
    public int maxNumberOfStudents;

    public void getMathematicsCourseDetails()
    {
        CourseDetails Mathematics = new CourseDetails();
        Mathematics.CourseName = Subjects.Mathematics.ToString();
        Mathematics.GradeEntry = Grades.B.ToString();
        Mathematics.LengthOfCourse = 4;
        Mathematics.maxNumberOfStudents = 25;

        Console.WriteLine($"Course Name: {Mathematics.CourseName}");
        Console.WriteLine($"Entry Requirements: {Mathematics.GradeEntry}");
        Console.WriteLine($"Length of Course: {Mathematics.LengthOfCourse}");
        Console.WriteLine($"Maximum number of Students: {Mathematics.maxNumberOfStudents}");
    }


    public void getHistoryCourseDetails()
    {
        CourseDetails History = new CourseDetails();
        History.CourseName = Subjects.History.ToString();
        History.GradeEntry = Grades.C.ToString();
        History.LengthOfCourse = 3;
        History.maxNumberOfStudents = 25;

        Console.WriteLine($"Course Name: {History.CourseName}");
        Console.WriteLine($"Entry Requirements: {History.GradeEntry}");
        Console.WriteLine($"Length of Course: {History.LengthOfCourse}");
        Console.WriteLine($"Maximum number of Students: {History.maxNumberOfStudents}");
    }

    public void getEngineeringCourseDetails()
    {
        CourseDetails Engineering = new CourseDetails();
        Engineering.CourseName = Subjects.Engineering.ToString();
        Engineering.GradeEntry = Grades.B.ToString();
        Engineering.LengthOfCourse = 4;
        Engineering.maxNumberOfStudents = 25;

        Console.WriteLine($"Course Name: {Engineering.CourseName}");
        Console.WriteLine($"Entry Requirements: {Engineering.GradeEntry}");
        Console.WriteLine($"Length of Course: {Engineering.LengthOfCourse}");
        Console.WriteLine($"Maximum number of Students: {Engineering.maxNumberOfStudents}");
    }

    public void getPhotographyCourseDetails()
    {
        CourseDetails Photography = new CourseDetails();
        Photography.CourseName = Subjects.Photography.ToString();
        Photography.GradeEntry = Grades.C.ToString();
        Photography.LengthOfCourse = 3;
        Photography.maxNumberOfStudents = 20;

        Console.WriteLine($"Course Name: {Photography.CourseName}");
        Console.WriteLine($"Entry Requirements: {Photography.GradeEntry}");
        Console.WriteLine($"Length of Course: {Photography.LengthOfCourse}");
        Console.WriteLine($"Maximum number of Students: {Photography.maxNumberOfStudents}");
    }

    public void GetCourseDetails()
    {
        Console.WriteLine("Please enter the number you would like to see course details for: ");
        Console.WriteLine("1: Mathematics, 2: History, 3: Engineering, 4: Photography");
        string userInput = Console.ReadLine();

        switch (userInput)
        {
            case "1":
                getMathematicsCourseDetails();
                break;
            case "2":
                getHistoryCourseDetails();
                break;
            case "3":
                getEngineeringCourseDetails();
                break;
            case "4":
                getPhotographyCourseDetails();
                break;
            default:
                Console.WriteLine("Invalid selection - please try again");
                return;
        }

    }

    public bool doesStudentPassEntryRequirements()
    {
        string courseNameInput;
        Console.WriteLine("Please enter the course you would like to apply to: ");
        Console.WriteLine("A: Mathematics, B: Engineering, C: History, D: Photography ");
        courseNameInput = Console.ReadLine().ToUpper();


        if (courseNameInput != "A" && courseNameInput != "B" && courseNameInput != "C" && courseNameInput != "D")
        {
            Console.WriteLine("Option not recognised, please try again");
        }
        else
        {
            Console.WriteLine("Please enter the grade you received: ");
            string gradeReceived = Console.ReadLine().ToUpper();
            switch (courseNameInput)
            {
                case "A":
                case "B":
                    if (gradeReceived == Grades.B.ToString() || gradeReceived == Grades.A.ToString())
                    {
                        Console.WriteLine("Congratulations - You are in!");
                        return true;
                    }
                    else if (gradeReceived == Grades.C.ToString() || gradeReceived == Grades.D.ToString() || gradeReceived == Grades.Fail.ToString())
                    {
                        Console.WriteLine("Sorry! Better luck next time");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter your grade as a letter, eg A, B or C");
                    }
                    break;
                case "C":
                case "D":
                    if (gradeReceived == Grades.B.ToString() || gradeReceived == Grades.A.ToString() || gradeReceived == Grades.C.ToString())
                    {
                        Console.WriteLine("Congratulations - You are in!");
                        return true;
                    }
                    else if (gradeReceived == Grades.D.ToString() || gradeReceived == Grades.Fail.ToString())
                    {
                        Console.WriteLine("Sorry! Better luck next time");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Please enter your grade as a letter, eg A, B or C");
                    }
                    break;
                default:
                    Console.WriteLine("Please enter your grade as a letter, eg A, B or C");
                    break;
            }
        }
        Console.WriteLine("---");
        return false;
    }

    public void DisplaySizeOfClass()
    {
        Console.WriteLine("The current class size is:");


    }
}