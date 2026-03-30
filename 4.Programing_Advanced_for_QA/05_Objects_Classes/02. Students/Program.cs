
public class Program
{

    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        List<Students> studentsList = new List<Students>();

        while (input != "end")
        {

            string firstName = input.Split(" ")[0];
            string lastName = input.Split(" ")[1];
            int age = int.Parse(input.Split(" ")[2]);
            string homeTown = input.Split(" ")[3];

            Students newStudent = new Students(firstName, lastName, age, homeTown);
            studentsList.Add(newStudent);
            input = Console.ReadLine();

        }

        string cityName = Console.ReadLine();

        foreach (Students student in studentsList)
        {
            if (student.HomeTown == cityName)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }
        }

    }


}
