
namespace MiniProjects.StudentAverage
{
    class StudentAverage
    {
        static double GradeAverage(int a, int b, int c, int d, int e)
        {
            return (a + b + c + d + e) / 5.0;
        }

        static char GradeLetter(double grades)
        {
            if (grades > 90) return 'A';
            if (grades > 80) return 'B';
            if (grades > 70) return 'C';
            if (grades > 50) return 'D';
            else return 'F';
        }

        static void PrintAverage(string name, int a, int b, int c, int d, int e)
        {
            double avg = GradeAverage(a, b, c, d, e);
            Console.Write($"{name}: {avg} {GradeLetter(avg)}");
        }

        public static void Run()
        {
            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            PrintAverage("Sophia", sophia1, sophia2, sophia3, sophia4, sophia5);
            PrintAverage("Nicolas", nicolas1, nicolas2, nicolas3, nicolas4, nicolas5);
            PrintAverage("Zahirah", zahirah1, zahirah2, zahirah3, zahirah4, zahirah5);
            PrintAverage("Jeong", jeong1, jeong2, jeong3, jeong4, jeong5);
        }
    }
}