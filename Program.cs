using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using IndividualProject.Admin;
using IndividualProject.Student;

namespace IndividualProject
{
    internal class Program
    {

        static void Main(string[] args)
        {
            

            string password = "password";
            string username = "username";
            int retries = 3;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("********************");
            Console.WriteLine("Welcome to the Open University");
            Console.WriteLine("********************");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter the options that is applicable to you: \n1: Admin \n2: Students \n9: Exit Application");

            string userInput = Console.ReadLine();



            if (userInput == "1")
            {
                AdminOptions adminOptions = new AdminOptions();

                AdminEntry adminEntry = new AdminEntry(username, password, retries);
                bool successfulLogin = adminEntry.verifyAdminEntry();
                if (successfulLogin)
                {
                    adminOptions.DisplayAdminOptions();
                }
                else
                {
                    Console.WriteLine("Unsuccessful login");
                }

            }
            else if (userInput == "2")
            {
                StudentOptions options = new StudentOptions();
                StudentOptions.DisplayStudentOptions();
            }
            else if (userInput == "9")
            {
                Console.WriteLine("Thank you using the application!");
            }
            else
            {
                Console.WriteLine("Option not recognised - please try again");
            }


        }
    }
}