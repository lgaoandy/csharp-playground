// https://learn.microsoft.com/en-ca/training/modules/csharp-evaluate-boolean-expressions/6-exercise-challenge-boolean-expressions

namespace MiniProjects.PermissionsAndLevels
{
    class PermissionsAndLevels
    {
        public static void Run()
        {
            string permission = "Admin|Manager";
            int level = 55;
            string message = "You do not have sufficient privileges.";

            if (permission.Contains("Admin"))
            {
                message = (level > 55) ? "Welcome, Super Admin user" : "Welcome, Admin user.";
            }
            else if (permission.Contains("Manager") && level >= 20)
            {
                message = "Contact an Admin for access.";
            }
            Console.WriteLine(message);
        }
    }
}