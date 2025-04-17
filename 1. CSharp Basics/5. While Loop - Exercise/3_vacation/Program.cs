double vacationPrice = double.Parse(Console.ReadLine());
double money = double.Parse(Console.ReadLine());

int spendingDays = 0;
int allDays = 0;

while (true)
{
    string action = Console.ReadLine();
    double moneyForAction = double.Parse(Console.ReadLine());

    if (action == "save")
    {
        money += moneyForAction;
        spendingDays = 0;
    }
    else if (action == "spend")
    {
        money -= moneyForAction;

        if (money < 0)
        {
            money = 0;
        }
        
        spendingDays += 1;
    }

    allDays += 1;

    if (spendingDays == 5)
    {
        Console.WriteLine("You can't save the money.");
        Console.WriteLine($"{allDays}");
        break;
    }

    if (money >= vacationPrice)
    {
        Console.WriteLine($"You saved the money for {allDays} days.");
        break;
    }
}