string userName;
int userAge;
string userZodiacSign;

Console.WriteLine("Как вас зовут?");
userName = Console.ReadLine();
Console.WriteLine("Сколько Вам лет?");
userAge = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Какой у Вас знак зодиака?");
userZodiacSign = Console.ReadLine();

Console.WriteLine($"Всё ясно!\nВас зовут {userName}, Вам {userAge} лет и вы по гороскопу {userZodiacSign}");