using IndividualProject.Course;
using IndividualProject.People;

namespace IndividualProject.Student;

public class StudentOptions
{
    //private static List<Teacher> Teachers;
    private static CourseDetails courseDetails = new CourseDetails();



    public static void DisplayStudentOptions()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("********************");
        Console.WriteLine("Welcome to the student portal!");
        Console.WriteLine("********************");
        Console.ForegroundColor = ConsoleColor.White;

        string userSelection;

        do
        {
            Console.WriteLine("--------");
            Console.WriteLine("Please enter a selection:");
            Console.WriteLine(
                "1:Get Course Details \n2:Get Teacher Details \n3:Check your grade\n4:Check Course Entry Requirements \n5:Exit Application");
            Console.WriteLine("--------");


            userSelection = Console.ReadLine();
            ;

            if (userSelection == "1")
            {
                courseDetails.GetCourseDetails();
            }
            else if (userSelection == "2")
            {
                Teacher getTeachers = new Teacher();
                getTeachers.getTeachersList();
            }
            else if (userSelection == "3")
            {
                GradingCriteria grading = new GradingCriteria();
                Console.WriteLine("Please enter your score:");
                string userInput = Console.ReadLine();
                int grade = Convert.ToInt32(userInput);
                GradingCriteria.gradingCriteria(grade);
            }
            else if (userSelection == "4")
            {
                courseDetails.doesStudentPassEntryRequirements();
            }
            else if (userSelection == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Option is not recognised, Please try again");
            }
        }
        while (userSelection != "5");

        Console.WriteLine("Thank you for using the application!");

    }
}