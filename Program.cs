Console.Write("Введите количество элементов в массиве: ");
string userInput = Console.ReadLine();

int arrayDimension;

while(int.TryParse(userInput, out arrayDimension) == false)
{
    Console.Clear();
    Console.WriteLine("Неверно! Вам нужно ввести число!");
    userInput = Console.ReadLine();
}

int[] array = new int[arrayDimension];

for(int i = 0; i < arrayDimension; i++)
{
    array[i] = i + 1;
}

string commandRightShift = "->";
string commanLeftShift = "<-";
string commandExit = "esc";
bool isRun = true;
int tempCell;
int firstIndex = 0;

while(isRun)
{
    Console.Clear();
    Console.WriteLine("Исходный массив: ");

    for(int i = 0; i < arrayDimension; i++)
    {
        Console.Write(array[i] + " ");
    }

    Console.WriteLine($"Куда вы хотите сдвинуть массив?\n{commanLeftShift} - сдвиг значений массива влево\n{commandRightShift} - сдвиг значений массива вправо\n{commandExit} - выход из программы");
    ConsoleKeyInfo userController = Console.ReadKey();

    switch(userController.Key)
    {
        case ConsoleKey.LeftArrow:
            tempCell = array[firstIndex];

            for(int i = 1; i < arrayDimension; i++)
            {
                array[i - 1] = array[i];
            }

            array[arrayDimension - 1] = tempCell;
        break;

        case ConsoleKey.RightArrow:
            tempCell = array[arrayDimension - 1];

            for(int i = arrayDimension - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[firstIndex] = tempCell;
        break;

        case ConsoleKey.Escape:
            isRun = false;
        break;

        default:
        Console.WriteLine("Неверная команда!");
        break;
    }
}