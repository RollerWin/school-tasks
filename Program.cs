const string CommandExit = "exit";

const string SelectRubCommand = "1";
const string SelectUsdCommand = "2";
const string SelectEurCommand = "3";

const int ConvertRubToUsdCommand = 1;
const int ConvertRubToEurCommand = 2;

const int ConvertUsdToRubCommand = 1;
const int ConvertUsdToEurCommand = 2;

const int ConvertEurToRubCommand = 1;
const int ConvertEurToUsdCommand = 2;

double usdToRub = 89.90;
double rubToUsd = 0.011;
double eurToRub = 97.08;
double rubToEur = 0.01;
double eurToUsd = 0.91;
double usdToEur = 1.10;

double userRubles;
double userDollars;
double userEuros;
double currencyForExchange;

bool isRun = true;

Console.Write("Введите, сколько у вас рублей: ");
userRubles = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, сколько у вас долларов: ");
userDollars = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите, сколько у вас евро: ");
userEuros = Convert.ToDouble(Console.ReadLine());
Console.Clear();

while(isRun)
{
    Console.WriteLine($"У Вас\n{userRubles} рублей\n{userDollars} долларов\n{userEuros} евро");
    Console.WriteLine($"Выберите валюту, которую хотите обменять:\n{SelectRubCommand} - выбрать рубли\n{SelectUsdCommand} - выбрать доллары\n{SelectEurCommand} - выбрать евро");

    switch(Console.ReadLine())
    {
        case SelectRubCommand:
            Console.WriteLine($"Выберите, на какую валюту вы хотите обменять:\n{ConvertRubToUsdCommand} - обменять на доллары\n{ConvertRubToEurCommand} - обменять на евро");

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case ConvertRubToUsdCommand:
                    Console.Write("Введите число рублей, которое хотите обменять: ");
                    currencyForExchange = Convert.ToDouble(Console.ReadLine());

                    if(currencyForExchange <= userRubles) 
                    {
                        userRubles -= currencyForExchange;
                        userDollars += currencyForExchange * rubToUsd;
                    }
                break;

                case ConvertRubToEurCommand:
                    Console.Write("Введите число рублей, которое хотите обменять: ");
                    currencyForExchange = Convert.ToDouble(Console.ReadLine());

                    if(currencyForExchange <= userRubles) 
                    {
                        userRubles -= currencyForExchange;
                        userEuros += currencyForExchange * rubToEur;
                    }
                break;

                default:
                    Console.WriteLine("Увы, такой команды нет! попробуйте с самого начала!");
                break;
            }
        break;

        case SelectUsdCommand:
            Console.WriteLine($"Выберите, на какую валюту вы хотите обменять:\n{ConvertUsdToRubCommand} - обменять на рубли\n{ConvertUsdToEurCommand} - обменять на евро");

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case ConvertRubToUsdCommand:
                    Console.Write("Введите число долларов, которое хотите обменять: ");
                    currencyForExchange = Convert.ToDouble(Console.ReadLine());

                    if(currencyForExchange <= userDollars) 
                    {
                        userDollars -= currencyForExchange;
                        userRubles += currencyForExchange * usdToRub;
                    }
                break;

                case ConvertRubToEurCommand:
                    Console.Write("Введите число долларов, которое хотите обменять: ");
                    currencyForExchange = Convert.ToDouble(Console.ReadLine());

                    if(currencyForExchange <= userDollars) 
                    {
                        userDollars -= currencyForExchange;
                        userEuros += currencyForExchange * usdToEur;
                    }
                break;

                default:
                    Console.WriteLine("Увы, такой команды нет! попробуйте с самого начала!");
                break;
            }
        break;

        case SelectEurCommand:
            Console.WriteLine($"Выберите, на какую валюту вы хотите обменять:\n{ConvertEurToRubCommand} - обменять на рубли\n{ConvertEurToUsdCommand} - обменять на доллары");

            switch(Convert.ToInt32(Console.ReadLine()))
            {
                case ConvertRubToUsdCommand:
                    Console.Write("Введите число евро, которое хотите обменять: ");
                    currencyForExchange = Convert.ToDouble(Console.ReadLine());

                    if(currencyForExchange <= userEuros) 
                    {
                        userEuros -= currencyForExchange;
                        userRubles += currencyForExchange * eurToRub;
                    }
                break;

                case ConvertRubToEurCommand:
                    Console.Write("Введите число евро, которое хотите обменять: ");
                    currencyForExchange = Convert.ToDouble(Console.ReadLine());

                    if(currencyForExchange <= userEuros) 
                    {
                        userEuros -= currencyForExchange;
                        userDollars += currencyForExchange * eurToUsd;
                    }
                break;

                default:
                    Console.WriteLine("Увы, такой команды нет! попробуйте с самого начала!");
                break;
            }
        break;

        case CommandExit:
            isRun = false;
        break;

        default:
            Console.WriteLine("Такой команды нет! Попробуйте снова!");
        break;
    }

    Console.Clear();
}