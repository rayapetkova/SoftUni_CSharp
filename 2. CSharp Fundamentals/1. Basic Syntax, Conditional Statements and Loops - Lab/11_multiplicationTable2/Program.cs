int number = int.Parse(Console.ReadLine());
int start = int.Parse(Console.ReadLine());

if (start >= 10)
{
    Console.WriteLine($"{number} X {start} = {number * start}");
}
else
{
    for (int secondNum = start; secondNum <= 10; secondNum++)
    {
        Console.WriteLine($"{number} X {secondNum} = {number * secondNum}");
    }
}
