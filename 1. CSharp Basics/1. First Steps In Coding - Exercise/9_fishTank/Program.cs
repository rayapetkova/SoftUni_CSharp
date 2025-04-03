int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percents = double.Parse(Console.ReadLine());

double volume = length * width * height;
double volumeInL = volume / 1000;

double neededL = volumeInL * (1 - percents / 100);
Console.WriteLine(neededL);