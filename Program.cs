Random random = new Random();
int arrayDimension = 30;
int minCellValue = 1;
int maxCellValue = 5;

int[] array = new int[arrayDimension];

for(int i = 0; i < arrayDimension; i++)
{
    array[i] = random.Next(minCellValue, maxCellValue + 1);
}

int firstIndex = 0;
int mostRepeatedNumber = array[firstIndex];
int currentNumberOfRepetitions = 1;
int maxNumberOfRepetitions = 1;

Console.WriteLine($"Исходный массив размерности {arrayDimension}: ");

for(int i = 0; i < arrayDimension; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for(int i = 1; i < arrayDimension; i++)
{
    if(array[i] == array[i - 1])
    {
        currentNumberOfRepetitions++;

        if(currentNumberOfRepetitions > maxNumberOfRepetitions)
        {
            maxNumberOfRepetitions = currentNumberOfRepetitions;
            mostRepeatedNumber = array[i - 1];
        }
    }
    else
    {
        currentNumberOfRepetitions = 1;
    }
}

if(maxNumberOfRepetitions > 1)
{
    Console.WriteLine($"Больше всего повторялось число {mostRepeatedNumber}\nОно повторялось {maxNumberOfRepetitions} раз!");
}
else
{
    Console.WriteLine("В этом массиве совсем нет повторяющихся чисел :(");
}