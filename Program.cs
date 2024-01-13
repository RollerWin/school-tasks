string systemPassword = "qwerty";
bool isAuthorized = false;
int numberOfAttempts = 3;
string secretMessage = "aboba";
string userInput;

while(!isAuthorized && numberOfAttempts > 0)
{
    Console.Write("Введите пароль: ");
    userInput = Console.ReadLine();

    if(userInput == systemPassword)
    {
        isAuthorized = true;
        Console.WriteLine($"Пароль верный!\nСекретное сообщение: {secretMessage}");
    }
    else
    {
        numberOfAttempts--;
        Console.WriteLine($"Неверный пароль!\nУ вас осталось {numberOfAttempts} попыток");
    }
}

if(numberOfAttempts == 0)
{
    Console.WriteLine("Увы, количество попыток закончилось! Система выключается...");
}