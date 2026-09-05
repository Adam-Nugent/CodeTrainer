Console.WriteLine("CodeTrainer");
Console.WriteLine("===========");
Console.WriteLine();

string targetCode = "Console.WriteLine(\"Hello, World!\");";

Console.WriteLine("Type the statement exactly as shown:");
Console.WriteLine(targetCode);
Console.WriteLine();

Console.Write("Your attempt: ");
string userInput = Console.ReadLine() ?? "";

bool isCorrect = userInput == targetCode;

if (isCorrect)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine("Incorrect.");
}
