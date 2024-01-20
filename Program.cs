Random random = new Random();
int arrayDimension = 30;

int minCellValue = 1;
int maxCellValue = 10;

int maxArrayValue = minCellValue;

int[] array = new int[arrayDimension];

for(int i = 0; i < arrayDimension; i++)
{
    array[i] = random.Next(minCellValue, maxCellValue + 1);
}
