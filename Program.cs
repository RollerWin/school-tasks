int peopleInLine;
int timeOfReceiptInMinutes = 10;
int minutesInHour = 60;

Console.Write("Сколько бабушек Вы видите в очереди?");
peopleInLine = Convert.ToInt32(Console.ReadLine());

int totalTime = timeOfReceiptInMinutes * peopleInLine;
int hoursOfWaiting = totalTime / minutesInHour;
int minutesOfWaiting = totalTime % minutesInHour;

Console.WriteLine($"Вам осталось ждать {hoursOfWaiting} часов и {minutesOfWaiting} минут");