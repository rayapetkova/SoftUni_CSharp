int number = int.Parse(Console.ReadLine());

for (int secondNum = 1; secondNum <= 10; secondNum++)
{
    Console.WriteLine($"{number} X {secondNum} = {number * secondNum}");
}