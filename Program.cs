Random random = new Random();
int arrayDimension = 10;
int minCellValue = 1;
int maxCellValue = 100;
int tempCell;

int[] array = new int[arrayDimension];

for(int i = 0; i < arrayDimension; i++)
{
    array[i] = random.Next(minCellValue, maxCellValue + 1);
}

Console.WriteLine($"Исходный массив размерности {arrayDimension}: ");

for(int i = 0; i < arrayDimension; i++)
{
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for(int i = arrayDimension - 1; i > 0; i--)
{
    for(int j = 0; j < i; j++)
    {
        if(array[j] > array[j+1])
        {
            tempCell = array[j];
            array[j] = array[j+1];
            array[j+1] = tempCell;
        }
    }
}

Console.WriteLine("Отсортированный массив пузырьковым методом:");

for(int i = 0; i < arrayDimension; i++)
{
    Console.Write(array[i] + " ");
}