int minValue = 1;
int maxValue = 27;

int minThreeDigitNumber = 100;
int maxThreeDigitNumber = 999;

int exploreNumber;
int numberOfMultiplies = 0;

Random random = new Random();
int number = random.Next(minValue, maxValue + 1);

Console.WriteLine($"Случайное число от {minValue} до {maxValue}: {number}");

int minMultipleNumber = minThreeDigitNumber;
bool isFound = false;

while(isFound == false)
{
    exploreNumber = minMultipleNumber;

    while(exploreNumber > 0)
    {
        exploreNumber -= number;
    }

    if(exploreNumber == 0)
    {
        isFound = true;
    }
    else
    {
        minMultipleNumber++;
    }
}

for(int i = minMultipleNumber; i <= maxThreeDigitNumber; i += number)
{
    numberOfMultiplies++;
}

Console.WriteLine($"Количество чисел, кратных {number}: {numberOfMultiplies}");