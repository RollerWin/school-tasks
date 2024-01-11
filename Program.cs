int playerCoins;
int playerBag = 0;
int numberOfDiamonds = 20;
int diamondPrice = 5;

Console.Write("Укажите ваше количество монет: ");
playerCoins = Convert.ToInt32(Console.ReadLine());

Console.Write($"У вас {playerCoins} монет!\nНа рынке {numberOfDiamonds} алмазов\nСколько алмазов желаете приобрести?\t");
int diamondsToBuy = Convert.ToInt32(Console.ReadLine());

bool canBuyDiamonds = numberOfDiamonds >= diamondsToBuy;

int numberOfPurchasedDiamonds = diamondsToBuy * Convert.ToInt32(canBuyDiamonds);

int totalCost = diamondPrice * numberOfPurchasedDiamonds;
playerCoins -= totalCost;
numberOfDiamonds -= numberOfPurchasedDiamonds;
playerBag += numberOfPurchasedDiamonds;

Console.WriteLine($"Сделка состоялась!\nТеперь у Вас {playerCoins} монет\nНа рынке {numberOfDiamonds} алмазов\nА у вас теперь {playerBag} алмазов!");