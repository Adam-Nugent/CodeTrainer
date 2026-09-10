Console.WriteLine("CodeTrainer");
Console.WriteLine("===========");
Console.WriteLine();

string[] targetCodes =
{
    "Console.WriteLine(\"Hello, World!\");",
    "string language = \"C#\";",
    "bool isLearning = true;"
};

int score = 0;
int totalQuestions = targetCodes.Length;
int totalAttempts = 0;

for (int index = 0; index < targetCodes.Length; index++)
{
    string currentTargetCode = targetCodes[index];
    bool isCorrect = false;
    Console.WriteLine($"Exercise {index + 1} of {totalQuestions}");
    Console.WriteLine("Type the statement exactly as shown:");
    Console.WriteLine(currentTargetCode);
    Console.WriteLine();

    while (!isCorrect)
    {
        Console.Write("Your attempt: ");
        string userInput = Console.ReadLine() ?? "";

        totalAttempts = totalAttempts + 1;
        isCorrect = userInput == currentTargetCode;

        if (isCorrect)
        {
            score = score + 1;
            Console.WriteLine("Correct!");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Incorrect. Try again.");
            Console.WriteLine(currentTargetCode);
        }
    }
}

Console.WriteLine($"Score: {score}/{totalQuestions}");
Console.WriteLine($"Total attempts: {totalAttempts}");
