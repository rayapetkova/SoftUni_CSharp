int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

int sum = 0;
string finalResult = "";

for (int num = start; num <= end; num++)
{
    sum += num;
    finalResult += $"{num} ";
}

Console.WriteLine(finalResult);
Console.WriteLine($"Sum: {sum}");