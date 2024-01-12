const string ExitCommand = "exit";
const string ShowInfoCommand = "show info";
const string LogInCommand = "login";
const string RegisterCommand = "register";
const string ChangeConsoleColorCommand = "change color";
const string ShowInstructionsCommand ="help";

const string SelectWhiteConsoleCommand = "white";
const string SelectGreenConsoleCommand = "green";
const string SelectBlueConsoleCommand = "blue";
const string SelectRedConsoleCommand = "red";
const string SelectYellowConsoleCommand = "yellow";

string userName = "";
string password = "";

string currentUserName = "";
string currentPassword = "";

string userInput;
bool isRun = true;
bool isAuthorize = false;


while(isRun)
{
    Console.WriteLine($"Добро пожаловать в консоль!\nДля помощи по командам напиши {ShowInstructionsCommand}");

    userInput = Console.ReadLine();
    Console.Clear();

    switch(userInput)
    {
        case ShowInstructionsCommand:
            Console.WriteLine($"Команды:\n{ShowInfoCommand} - показать информацию о пользователе\n{LogInCommand} - авторизация\n{RegisterCommand} - регистрация\n{ChangeConsoleColorCommand} - изменить цвет консоли\n{ShowInstructionsCommand} - список команд\n{ExitCommand} - выход");
        break;

        case ChangeConsoleColorCommand:
            if(isAuthorize)
            {
                Console.WriteLine("Выберите, в какой цвет хотите окрасить консоль:");
                Console.WriteLine($"{SelectWhiteConsoleCommand} - белый\n{SelectGreenConsoleCommand} - зелёный\n{SelectBlueConsoleCommand} - синий\n{SelectRedConsoleCommand} - красный\n{SelectYellowConsoleCommand} - жёлтый");

                switch(Console.ReadLine())
                {
                    case SelectWhiteConsoleCommand:
                        Console.ForegroundColor = ConsoleColor.White;
                    break;

                    case SelectGreenConsoleCommand:
                        Console.ForegroundColor = ConsoleColor.Green;
                    break;

                    case SelectBlueConsoleCommand:
                        Console.ForegroundColor = ConsoleColor.Blue;
                    break;

                    case SelectRedConsoleCommand:
                        Console.ForegroundColor = ConsoleColor.Red;
                    break;

                    case SelectYellowConsoleCommand:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    break;

                    default:
                        Console.WriteLine("Такой команды нет!");
                    break;
                }
            }
            else 
            {
                Console.WriteLine("Вы не авторизованы!");
            }
        break;

        case RegisterCommand:
            Console.Write("Введите своё имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите свой пароль: ");
            password = Console.ReadLine();
            Console.Write("Повторите свой пароль: ");

            if(Console.ReadLine() == password)
            {
                Console.WriteLine("Пользователь зарегистрирован!");
            }     
            else
            {
                Console.WriteLine("Регистрация провалена!");
                userName = "";
                password = "";
            }
        break;

        case LogInCommand:
            if(userName != "" && password != "")
            {
                Console.Write("Введите своё имя: ");
                currentUserName = Console.ReadLine();
                Console.Write("Введите свой пароль: ");
                currentPassword = Console.ReadLine();
            
                if(currentUserName == userName && currentPassword == password && userName != "" && password != "")
                {
                    Console.WriteLine("Вы успешно авторизовались!");
                    isAuthorize = true;
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверный логин или пароль!");
                    currentUserName = "";
                    currentPassword = "";
                }
            }
            else
            {
                Console.WriteLine("Вы даже не зарегистрированы!");
            }
        break;

        case ShowInfoCommand:
            if(isAuthorize)
            {
                Console.Clear();
                Console.WriteLine($"Ваше имя: {currentUserName}\nВаш пароль: {currentPassword}");
            }
            else
            {
                Console.WriteLine("Вы не авторизованы!");
            }
        break;

        case ExitCommand:
            isRun = false;
        break;

        default:
            Console.WriteLine("Неизвестная команда! Попробуй ещё раз!");
        break;
    }

    Console.ReadKey();
    Console.Clear();
}