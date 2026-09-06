Console.WriteLine("CodeTrainer");
Console.WriteLine("===========");
Console.WriteLine();

string targetCode = "Console.WriteLine(\"Hello, World!\");";
int score = 0;
int totalQuestions = 1;

Console.WriteLine("Type the statement exactly as shown:");
Console.WriteLine(targetCode);
Console.WriteLine();

Console.Write("Your attempt: ");
string userInput = Console.ReadLine() ?? "";

bool isCorrect = userInput == targetCode;

if (isCorrect)
{
    score = score + 1;
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect.");
}

Console.WriteLine($"Score: {score}/{totalQuestions}");
