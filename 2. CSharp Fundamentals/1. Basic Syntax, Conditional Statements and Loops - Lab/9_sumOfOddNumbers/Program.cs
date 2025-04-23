int n = int.Parse(Console.ReadLine());

int number = 1;
int allNums = 0;

int oddNumbersSum = 0;

while (allNums < n)
{
    oddNumbersSum += number;

    Console.WriteLine(number);

    number += 2;
    allNums++;
}

Console.WriteLine($"Sum: {oddNumbersSum}");