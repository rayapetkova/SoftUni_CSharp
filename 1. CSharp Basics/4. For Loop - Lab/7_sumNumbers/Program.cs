int numbersCount = int.Parse(Console.ReadLine());

int totalSum = 0;

for (int n = 0; n < numbersCount; n++)
{
    int number = int.Parse(Console.ReadLine());
    totalSum += number;
}

Console.WriteLine(totalSum);