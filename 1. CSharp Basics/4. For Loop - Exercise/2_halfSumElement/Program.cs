int numbersCount = int.Parse(Console.ReadLine());

int biggestNum = int.MinValue;
int sum = 0;

for (int i = 0; i < numbersCount; i++)
{
    int number = int.Parse(Console.ReadLine());

    if (number > biggestNum)
    {
        biggestNum = number;
    }

    sum += number;
}

sum -= biggestNum;

if (biggestNum == sum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sum}");
}
else
{
    Console.WriteLine("No");
    Console.WriteLine($"Diff = {Math.Abs(biggestNum - sum)}");
}