using IndividualProject.Course;
using IndividualProject.People;

namespace IndividualProject.Admin;

public class AdminOptions
{
    private static CourseDetails courseDetails = new CourseDetails();


    public void DisplayAdminOptions()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("********************");
        Console.WriteLine("Welcome to the Admin portal!");
        Console.WriteLine("********************");
        string userSelection;
        Console.ForegroundColor = ConsoleColor.White;

        do
        {
            Console.WriteLine("--------");
            Console.WriteLine("Please enter a selection:");
            Console.WriteLine(
                "1:Get Course Details, \n2:Get Teacher Details, \n3:Get Student Details, \n4:Exit Application");
            Console.WriteLine("--------");

            userSelection = Console.ReadLine();

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
                People.Student students = new People.Student();
                students.getStudentDetails();
            }
            else if (userSelection == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid selection please try again");
            }
        } while (userSelection != "4");

        Console.WriteLine("Thank you for using the application");

    }
}