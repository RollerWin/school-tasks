int firstDimension = 0;
int[] array = new int[firstDimension];

string userInput = "";
string commandExit = "exit";
string commandSum = "sum";

bool isWork = true;

int arraySum = 0;

while(isWork == true)
{
    Console.WriteLine($"Введите число либо\n{commandExit} для выхода из программы, либо\n{commandSum} для суммы ранее введённых чисел");

    userInput = Console.ReadLine();

    if(userInput == commandExit)
    {
        isWork = false;       
    }
    else if(userInput == commandSum)
    {
        for(int i = 0; i < array.Length; i++)
        {
            arraySum += array[i];
        }

        Console.WriteLine($"Сумма ранее введённых чисел: {arraySum}");
        arraySum = 0;
    }
    else
    {
        int[] newArray = new int[array.Length + 1];

        for(int i = 0; i < array.Length; i++)
        {
            newArray[i] = array[i];
        }
        
        array = newArray;
        array[array.Length - 1] = Convert.ToInt32(userInput);
    }
}