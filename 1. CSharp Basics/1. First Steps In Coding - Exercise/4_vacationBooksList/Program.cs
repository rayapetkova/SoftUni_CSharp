int pagesInBook = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int days = int.Parse(Console.ReadLine());

double hours = pagesInBook / 20;
double hoursPerDay = hours / days;

Console.WriteLine(hoursPerDay);