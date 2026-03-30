namespace _02._Articles
{
    public class Program
    {
        public static void Main(string[] args)
        {

            string[] informationFromConsole = Console.ReadLine().Split(", ").ToArray();

            string inputedTitle = informationFromConsole[0];
            string inputedContet = informationFromConsole[1];
            string inputedAuthor = informationFromConsole[2];

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] change = Console.ReadLine().Split(": ").ToArray();

                if (change[0] == "Edit")
                {
                    inputedContet = change[1];
                }
                else if (change[0] == "ChangeAuthor")
                {
                    inputedAuthor = change[1];
                }
                else
                {
                    inputedTitle = change[1];
                }
            }

            string endResult = ($"{inputedTitle} - {inputedContet}: {inputedAuthor}");

            Console.WriteLine(endResult.ToString());
        }






    }
}
