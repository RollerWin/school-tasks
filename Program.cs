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
        break;
    }
    else
    {
        Console.WriteLine($"Неверный пароль!\nУ вас осталось {i} попыток");
    }

    if(i == 0)
    {
        Console.WriteLine("Увы, количество попыток закончилось! Система выключается...");
    }
}

