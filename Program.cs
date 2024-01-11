const int PICTURES_IN_ROW = 3;

int numberOfPictures = 52;

Console.WriteLine($"Из {numberOfPictures} картин получилось {numberOfPictures / PICTURES_IN_ROW} рядов.\nСверх меры оказалось {numberOfPictures % PICTURES_IN_ROW} картин");