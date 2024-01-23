namespace IndividualProject.Admin;

public class AdminEntry
{
    AdminOptions options = new AdminOptions();
    string AdminPassword; // Need to set as a property and only as a set
    string AdminUserName;
    int numberOfRetries;

    public AdminEntry(string UserName, string Password, int Retries)
    {
        AdminUserName = UserName;
        AdminPassword = Password;
        numberOfRetries = Retries;
    }
    public bool verifyAdminEntry()
    {

        for (int attempt = 1; attempt <= numberOfRetries; attempt++)
        {
            Console.WriteLine("Please enter the username: ");

            string inputUsername = Console.ReadLine();
            Console.WriteLine("Please enter the correct password to proceed: ");
            string inputPassword = Console.ReadLine();

            if (inputPassword == AdminPassword && inputUsername == AdminUserName)
            {
                return true;
            }
            else
            {
                Console.WriteLine($"Incorrect password - attempt {attempt}/ 3");
            }
        }

        return false;
    }
}