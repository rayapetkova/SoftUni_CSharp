int numbersCount = int.Parse(Console.ReadLine());

double under200 = 0.0;
double under399 = 0.0;
double under599 = 0.0;
double under799 = 0.0;
double above800 = 0.0;

for (int i = 0; i < numbersCount; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number < 200)
    {
        under200 += 1;
    }
    else if (number <= 399)
    {
        under399 += 1;
    }
    else if (number <= 599)
    {
        under599 += 1;
    }
    else if (number <= 799)
    {
        under799 += 1;
    }
    else 
    {
        above800 += 1;
    }
}

double under200Percents = under200 / numbersCount * 100;
double under399Percents = under399 / numbersCount * 100;
double under599Percents = under599 / numbersCount * 100;
double under799Percents = under799 / numbersCount * 100;
double above800Percents = above800 / numbersCount * 100;

Console.WriteLine($"{under200Percents:F2}%");
Console.WriteLine($"{under399Percents:F2}%");
Console.WriteLine($"{under599Percents:F2}%");
Console.WriteLine($"{under799Percents:F2}%");
Console.WriteLine($"{above800Percents:F2}%");