Random number = new Random();
int minArrayValue = 2;
int maxArrayValue = 10;

int minCellValue = 1;
int maxCellValue = 100;

int indexRowSum = 1;
int indexColumnProduct = 0;

int rowSum = 0;
int columnProduct = 1;

int arrayRowLength = number.Next(minArrayValue, maxArrayValue + 1);
int arrayColumnLength = number.Next(minArrayValue, maxArrayValue + 1);

int[,] array = new int[arrayColumnLength, arrayRowLength];

for(int i = 0; i < arrayColumnLength; i++)
{
    for(int j = 0; j < arrayRowLength; j++)
    {
        array[i,j] = number.Next(minCellValue, maxCellValue);
    }
}

Console.WriteLine($"Исходная матрица размерности {arrayColumnLength} на {arrayRowLength}");

for(int i = 0; i < arrayColumnLength; i++)
{
    for(int j = 0; j < arrayRowLength; j++)
    {
        Console.Write(array[i,j] + " ");
    }

    Console.WriteLine();
}

for(int i = 0; i < arrayRowLength; i++)
{
    rowSum += array[indexRowSum, i];
}

Console.WriteLine($"Сумма чисел ряда {indexRowSum + 1}: {rowSum}");

for(int i = 0; i < arrayColumnLength; i++)
{
    columnProduct *= array[i, indexColumnProduct];
}

Console.WriteLine($"Произведение чисел ряда {indexColumnProduct + 1}: {columnProduct}");