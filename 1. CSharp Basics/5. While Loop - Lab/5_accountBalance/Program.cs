string input = Console.ReadLine();

double totalSum = 0.0;

while (input != "NoMoreMoney")
{
    double money = double.Parse(input);

    if (money < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    totalSum += money;
    Console.WriteLine($"Increase: {money:F2}");
    input = Console.ReadLine();
}

Console.WriteLine($"Total: {totalSum:F2}");