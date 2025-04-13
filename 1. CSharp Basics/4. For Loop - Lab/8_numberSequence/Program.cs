int numbersCount = int.Parse(Console.ReadLine());

int maxNum = int.MinValue;
int minNum = int.MaxValue;

for (int n = 0; n < numbersCount; n++)
{
    int number = int.Parse(Console.ReadLine());

    if (number > maxNum)
    {
        maxNum = number;
    }

    if (number < minNum)
    {
        minNum = number;
    }
}

Console.WriteLine($"Max number: {maxNum}");
Console.WriteLine($"Min number: {minNum}");