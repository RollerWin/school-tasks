char userBorderSymbol;
string userBorder = "";
string userName;

Console.Write("Введите своё имя:");
userName = Console.ReadLine();
Console.Write("Введите сивол для обводки: ");
userBorderSymbol = Convert.ToChar(Console.ReadLine());
string middleLine = $"{userBorderSymbol}{userName}{userBorderSymbol}";

for(int i = 0; i < middleLine.Length; i++)
{
    userBorder = string.Concat(userBorder, userBorderSymbol);
}

Console.WriteLine(userBorder);
Console.WriteLine(middleLine);
Console.WriteLine(userBorder);