char openBracket = '(';
char closeBracket = ')';
int bracketCounter = 0;
int maxBracketDepth = 0;


string correctResultMessage = "Выражение верно!";
string incorrectResultMessage = "Неверное выражение!";

bool isCorrect = true;

Console.Write("Введите скобочное выражение: ");
string userInput = Console.ReadLine();

foreach(var symbol in userInput)
{
    if(symbol == openBracket)
    {
        bracketCounter++;
        
        if(bracketCounter > maxBracketDepth)
        {
            maxBracketDepth = bracketCounter;
        }
    }
    else if(symbol == closeBracket)
    {
        bracketCounter--;
    }
    else
    {
        isCorrect = false;
        break;
    }
}

if(bracketCounter == 0 && isCorrect == true)
{
    Console.WriteLine(correctResultMessage);
    Console.WriteLine($"Максимальная глубина вложенности: {maxBracketDepth}");
}
else
{
    Console.WriteLine(incorrectResultMessage);
}