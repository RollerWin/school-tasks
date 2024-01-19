Random number = new Random();
int arrayDimension = 10;

int minCellValue = 1;
int maxCellValue = 100;

int maxArrayValue = minCellValue;

int[,] array = new int[arrayDimension, arrayDimension];

Console.WriteLine($"Исходная матрица размерности {arrayDimension} на {arrayDimension}");

for(int i = 0; i < arrayDimension; i++)
{
    for(int j = 0; j < arrayDimension; j++)
    {
        array[i,j] = number.Next(minCellValue, maxCellValue + 1);
        Console.Write(array[i,j] + " ");

        if(array[i,j] > maxArrayValue)
        {
           maxArrayValue = array[i,j];
        }
    }

    Console.WriteLine();
}

Console.WriteLine($"Максимальный элемент в матрице: {maxArrayValue}");
Console.WriteLine("Итоговый вариант матрицы: ");

for(int i = 0; i < arrayDimension; i++)
{
    for(int j = 0; j < arrayDimension; j++)
    {
        if(array[i,j] == maxArrayValue)
        {
            array[i,j] = 0;
        }

        Console.Write(array[i,j] + " ");
    }

    Console.WriteLine();
}