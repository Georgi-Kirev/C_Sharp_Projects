namespace _01._Students
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Students> studentsList = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] informationFromConsole = Console.ReadLine().Split(" ").ToArray();

                string inputedFirstName = informationFromConsole[0];
                string inputedLastName = informationFromConsole[1];
                double inputedGrade = double.Parse(informationFromConsole[2]);

                Students newStudent = new Students(inputedFirstName, inputedLastName, inputedGrade);
                studentsList.Add(newStudent);

            }

            foreach (Students index in studentsList.OrderByDescending(s => s.Grade))
            {
                Console.WriteLine($"{index.FirstName} {index.LastName}: {index.Grade:F2}");
            }
        }
    }
}
