Random random = new Random();
int number = random.Next(101);

int firstMultiple = 3;
int secondMultiple = 5;

int sumOfMultiples = 0;

for(int i = 0; i <= number; i++) 
{
    if(i % firstMultiple == 0 || i % secondMultiple == 0)
    {
        sumOfMultiples += i;
    }
}

Console.WriteLine($"Сумма всех положительных чисел меньше {number}, которые кратные {firstMultiple} или {secondMultiple}: {sumOfMultiples}");