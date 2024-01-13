string systemPassword = "qwerty";
int numberOfAttempts = 3;
string secretMessage = "aboba";
string userInput;

for(int i = numberOfAttempts - 1; i >= 0; i--)
{
    Console.Write("Введите пароль: ");
    userInput = Console.ReadLine();

    if(userInput == systemPassword)
    {
        Console.WriteLine($"Пароль верный!\nСекретное сообщение: {secretMessage}");
    }
    else
    {
        Console.WriteLine($"Неверный пароль!\nУ вас осталось {i} попыток");
    }
}