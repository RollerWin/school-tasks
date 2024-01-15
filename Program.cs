int minValue = 1;
int maxValue = 27;

int minThreeDigitNumber = 100;
int maxThreeDigitNumber = 999;

int numberOfMultiplies = 0;

Random random = new Random();
int number = random.Next(minValue, maxValue + 1);

Console.WriteLine($"Случайное число от {minValue} до {maxValue}: {number}");

for(int i = number; i <= maxThreeDigitNumber; i+= number)
{
    if(i >= minThreeDigitNumber)
    {
        numberOfMultiplies++;
        Console.WriteLine(i);
    }
}

Console.WriteLine($"Количество чисел, кратных {number}: {numberOfMultiplies}");