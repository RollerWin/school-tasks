char userBorderSymbol;
string userBorder = "";
string userName;

Console.Write("Введите своё имя:");
userName = Console.ReadLine();
Console.Write("Введите сивол для обводки: ");
userBorderSymbol = Convert.ToChar(Console.ReadLine());

for(int i = 0; i <= userName.Length + 1; i++)
{
    userBorder = string.Concat(userBorder, userBorderSymbol);
}

Console.WriteLine(userBorder);
Console.WriteLine(userBorderSymbol + userName + userBorderSymbol);
Console.WriteLine(userBorder);