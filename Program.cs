Console.WriteLine("CodeTrainer");
Console.WriteLine("===========");
Console.WriteLine();

string targetCode = "Console.WriteLine(\"Hello, World!\");";
int score = 0;
int totalQuestions = 1;
int attempts = 0;
bool isCorrect = false;

Console.WriteLine("Type the statement exactly as shown:");
Console.WriteLine(targetCode);
Console.WriteLine();

while (!isCorrect)
{
    Console.Write("Your attempt: ");
    string userInput = Console.ReadLine() ?? "";

    attempts = attempts + 1;
    isCorrect = userInput == targetCode;

    if (isCorrect)
    {
        score = score + 1;
        Console.WriteLine("Correct!");
    }
    else
    {
        Console.WriteLine("Incorrect. Try again.");
    }
}

Console.WriteLine($"Score: {score}/{totalQuestions}");
Console.WriteLine($"Attempts: {attempts}");
