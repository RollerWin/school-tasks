Random random = new Random();
int maxValue = 100;
int number = random.Next(maxValue + 1);
int compareNumber = 1;
int compareNumberBase = 2;
int powerOfСompareNumber = 0;

while(compareNumber <= number)
{
    compareNumber *= compareNumberBase;
    powerOfСompareNumber ++;
}

Console.WriteLine($"Случайное число - {number}\nЧисло c основанием {compareNumberBase}, которое больше - {compareNumber}\nСтепень этого числа - {powerOfСompareNumber}");