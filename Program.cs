char userBorderSymbol;
string userBorder = "";
string userName;

Console.Write("Введите своё имя:");
userName = Console.ReadLine();
Console.Write("Введите сивол для обводки: ");
userBorderSymbol = Convert.ToChar(Console.ReadLine());
int borderLength = 1 + userName.Length + 1;

for(int i = 0; i < borderLength; i++)
{
    userBorder = string.Concat(userBorder, userBorderSymbol);
}

Console.WriteLine(userBorder);
Console.WriteLine(userBorderSymbol + userName + userBorderSymbol);
Console.WriteLine(userBorder);