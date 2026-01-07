namespace MiniProjects.StudentGrading
{
    class StudentGrading
    {
        static string AssignLetterGrade(decimal grade)
        {
            if (grade >= 97) return "A+";
            if (grade >= 93) return "A";
            if (grade >= 90) return "A-";
            if (grade >= 87) return "B+";
            if (grade >= 83) return "B";
            if (grade >= 80) return "B-";
            if (grade >= 77) return "C+";
            if (grade >= 73) return "C";
            if (grade >= 70) return "C-";
            if (grade >= 67) return "D+";
            if (grade >= 63) return "D";
            if (grade >= 60) return "D-";
            return "F";
        }

        static decimal CalculateAverage(int[] scores)
        {
            decimal average = 0;
            foreach (int score in scores)
            {
                average += score;
            }
            return Math.Round(average / scores.Length, 2);
        }

        public static void Run()
        {
            Console.WriteLine($"Student\t\tGrade\n");

            string[] students = ["Sophia", "Andrew", "Emma", "Logan"];
            int[][] scores = [
                [90, 86, 87, 98, 100],
                [92, 89, 81, 96, 90],
                [90, 85, 87, 98, 68],
                [90, 95, 87, 88, 96]
            ];

            int i = 0;
            foreach (string student in students)
            {
                // Calculate average
                decimal average = CalculateAverage(scores[i]);
                string letterGrade = AssignLetterGrade(average);

                // Print 
                Console.WriteLine($"{student}:\t\t{average}\t{letterGrade}");
                i++;
            }

            Console.WriteLine("Press the Enter key to continue");
            Console.ReadKey();
        }
    }
}