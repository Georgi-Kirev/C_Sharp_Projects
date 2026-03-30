string[] text = File.ReadAllLines("Questions.txt");

List<string> questions = new List<string>();
List<string> answers = new List<string>();

for (int i = 0; i < text.Length; i++)
{
    if (i % 4 == 0)
    { questions.Add(text[i]); }
    else { answers.Add(text[i]); }
}

int questionsIndex = 0;
int answersIndex = 0;
int score = 0;

while (questionsIndex < questions.Count)
{
    Console.WriteLine(questions[questionsIndex]);
    questionsIndex++;

    int currectAnswerIndex = 0;

    for (int i = 0; i < 3; i++)
    {
        if (answers[answersIndex].StartsWith(">"))
        {
            currectAnswerIndex = i + 1;

            Console.WriteLine(i + 1 + "." + answers[answersIndex].Replace(">", ""));

        }
        else
        {
            Console.WriteLine($"{i + 1}. {answers[answersIndex]}");
        }
        answersIndex++;
    }
    int answer = int.Parse(Console.ReadLine());

    if (answer == currectAnswerIndex)
    {
        Console.WriteLine("Correct!");
        score++;
    }
    else
    {
        Console.WriteLine("Incorrect!");
    }

}

Console.WriteLine("End of quiz! You score was " + score);