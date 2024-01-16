char openBracket = '(';
char closeBracket = ')';
int bracketCounter = 0;

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
}
else
{
    Console.WriteLine(incorrectResultMessage);
}