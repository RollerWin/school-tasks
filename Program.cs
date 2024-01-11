int picturesInRow = 3;
int numberOfPictures = 52;

int numberOfRows = numberOfPictures / picturesInRow;
int picturesOverflow = numberOfPictures % picturesInRow;

Console.WriteLine($"Из {numberOfPictures} картин получилось {numberOfRows} рядов.\nСверх меры оказалось {picturesOverflow} картин");