string name = "Petrov";
string surname = "Vasiliy";

Console.WriteLine($"Ваше имя: {name}\nВаша фамилия: {surname}");
Console.WriteLine("Хм... Что-то не так...");

string wordBuffer = name;
name = surname;
surname = wordBuffer;

Console.WriteLine($"Теперь должно быть всё верно..\nВаше имя: {name}\nВаша фамилия: {surname}");