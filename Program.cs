string userInput;

Console.Write("Введите предложение: ");

userInput = Console.ReadLine();

string[] words = userInput.Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

foreach(var word in words)
{
    Console.WriteLine(word);
}