namespace IndividualProject.Course;

public class GradingCriteria
{

    internal static void gradingCriteria(int grade)
    {

        if (grade >= 80 && grade <= 100)
        {
            Console.WriteLine($"you have achieved a {Grades.A}");

        }
        else if (grade < 80 && grade >= 70)
        {
            Console.WriteLine($"you have achieved a {Grades.B}");
        }
        else if (grade < 70 && grade >= 60)
        {
            Console.WriteLine($"you have achieved a {Grades.C}");
        }
        else if (grade < 60 && grade >= 50)
        {
            Console.WriteLine($"you have achieved a {Grades.D}");
        }
        else if (grade < 50 && grade >= 40)
        {
            Console.WriteLine($"you have achieved a {Grades.E}");
        }
        else if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid score. Score should be between 0 - 100 - please try again");
        }

        else
        {
            Console.WriteLine($"you have achieved a {Grades.Fail}");
        }

    }
}