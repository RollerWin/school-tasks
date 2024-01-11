string userInput;
int userRepetitions;

Console.Write("Введите фразу, которая должна повторяться: ");
userInput = Console.ReadLine();

Console.Write("Введите число повторений: ");
userRepetitions = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i < userRepetitions; i++) 
{
    Console.WriteLine(userInput);
}