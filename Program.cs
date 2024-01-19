Random random = new Random();
int arrayDimension = 0;

int firstIndex = 0;
int secondIndex = 1;
int lastIndex = arrayDimension - 1;
int penultimateIndex = lastIndex - 1;

int minCellValue = 1;
int maxCellValue = 10;

int[] array = new int[arrayDimension];

Console.WriteLine("Исходная матрица:");

for(int i = 0; i < arrayDimension; i++)
{
    array[i] = random.Next(minCellValue, maxCellValue + 1);
    Console.Write(array[i] + " ");
}

Console.Write("\nСписок локальных максимумов: ");

if(array.Length == 1)
{
    Console.Write(array[firstIndex] + " ");
}
else if(array.Length == 2)
{
    if(array[firstIndex] > array[lastIndex])
    {
        Console.Write(array[firstIndex] + " ");
    }
    else
    {
        Console.Write(array[lastIndex] + " ");
    }
}
else if(array.Length > 2)
{
    if(array[firstIndex] > array[secondIndex])
    {
        Console.Write(array[firstIndex] + " ");
    }

    for(int i = secondIndex; i < lastIndex; i++)
    {
        if(array[i] > array[i-1] && array[i] > array[i+1])
        {
            Console.Write(array[i] + " ");
        }
    }

    if(array[lastIndex] > array[penultimateIndex])
    {
        Console.Write(array[lastIndex] + " ");
    }
}
else
{
    Console.WriteLine("Размерность нулевая или неверно задана!");
}