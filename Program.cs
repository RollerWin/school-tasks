const string CommandUseRashamonSpell = "1";
const string CommandUseHuganzakuraSpell = "2";
const string CommandUseHealingSpell = "3";
const string CommandUseDamageSpell = "4";

double userHealth = 100.0;
double rashamonSpellCoefficientDamage = 0.9;
double huganzakuraSpellDamage = 35.0;
double healingSpellCoefficient = 1.25;
double damageSpell = 15.0;

double enemyHealth = 200.0;
double enemyDamage = 20.0;

bool isPhantomSummoned = false;
bool canUserBeAttacked = true;

int numberOfDecimalPlaces = 2;

while(userHealth > 0.0 && enemyHealth > 0.0)
{
    canUserBeAttacked = true;

    Console.Clear();
    Console.WriteLine($"\tАрена!\nЗдоровье игрока: {userHealth}\nЗдоровье врага: {enemyHealth}");
    Console.WriteLine($"Выберите действие:\n{CommandUseRashamonSpell} - Призвать духа-помощника\n{CommandUseHuganzakuraSpell} - Нанести урон духом\n{CommandUseHealingSpell} - Восстановить здоровье\n{CommandUseDamageSpell} - Нанести урон самому");

    switch(Console.ReadLine())
    {
        case CommandUseRashamonSpell:
            isPhantomSummoned = true;
            userHealth = Math.Round(userHealth * rashamonSpellCoefficientDamage, numberOfDecimalPlaces);
        break;

        case CommandUseHuganzakuraSpell:
            if(isPhantomSummoned == true)
            {
                enemyHealth -= huganzakuraSpellDamage;
            }
            else
            {
                Console.WriteLine("Вы не призвали духа!");
            }
        break;

        case CommandUseHealingSpell:
            canUserBeAttacked = false;
            userHealth = Math.Round(userHealth * healingSpellCoefficient, numberOfDecimalPlaces);
        break;

        case CommandUseDamageSpell:
            enemyHealth -= damageSpell;
        break;

        default:
            Console.WriteLine("Неверная команда!");
        break;
    }

    if(canUserBeAttacked == true)
    {
        userHealth = Math.Round(userHealth - enemyDamage, numberOfDecimalPlaces);
    }
}

if(userHealth <= 0 && enemyHealth <= 0)
{
    Console.WriteLine("Ничья!");
}
else if(userHealth > 0)
{
    Console.WriteLine("Игрок победил!");
}
else
{
    Console.WriteLine("Враг победил!");
}