using System.Runtime.Serialization;

const string useRashamonSpellCommand = "1";
const string useHuganzakuraSpellCommand = "2";
const string useHealingSpellCommand = "3";
const string useDamageSpellCommand = "4";

double userHealth = 100.0;

double rashamonSpellCoefficientDamage = 0.9;

double huganzakuraSpellDamage = 35.0;

double healingSpellCoefficient = 1.25;

double damageSpell = 15.0;

double enemyHealth = 200.0;
double enemyDamage = 20.0;

bool isPhantomSummoned = false;
bool canUserBeAttacked = true;

while(userHealth > 0.0 && enemyHealth > 0.0)
{
    canUserBeAttacked = true;

    Console.Clear();
    Console.WriteLine($"\tАрена!\nЗдоровье игрока: {}\nЗдоровье врага: {enemyHealth}");
    Console.WriteLine($"Выберите действие:\n{useRashamonSpellCommand} - Призвать духа-помощника\n{useHuganzakuraSpellCommand} - Нанести урон духом\n{useHealingSpellCommand} - Восстановить здоровье\n{useDamageSpellCommand} - Нанести урон самому");

    switch(Console.ReadLine())
    {
        case useRashamonSpellCommand:
            isPhantomSummoned = true;
            userHealth = Math.Round(userHealth * rashamonSpellCoefficientDamage, 2);
        break;

        case useHuganzakuraSpellCommand:
            if(isPhantomSummoned == true)
            {
                enemyHealth -= huganzakuraSpellDamage;
            }
            else
            {
                Console.WriteLine("Вы не призвали духа!");
            }
        break;

        case useHealingSpellCommand:
            canUserBeAttacked = false;
            userHealth = Math.Round(userHealth * healingSpellCoefficient, 2);
        break;

        case useDamageSpellCommand:
            enemyHealth -= damageSpell;
        break;

        default:
            Console.WriteLine("Неверная команда!");
        break;
    }

    if(canUserBeAttacked == true)
    {
        userHealth = Math.Round(userHealth - enemyDamage, 2);
    }
}

if(userHealth <= 0)
{
    Console.WriteLine("Враг победил!");
}
else if(enemyHealth <= 0)
{
    Console.WriteLine("Игрок победил!");
}
else
{
    Console.WriteLine("Ничья!");
}