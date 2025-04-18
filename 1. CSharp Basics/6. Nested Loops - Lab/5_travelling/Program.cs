while (true)
{
    string destination = Console.ReadLine();

    if (destination == "End")
    {
        break;
    }

    double budget = double.Parse(Console.ReadLine());

    double workMoney = 0;

    while (true)
    {
        double money = double.Parse(Console.ReadLine());
        workMoney += money;

        if (workMoney >= budget)
        {
            Console.WriteLine($"Going to {destination}!");
            break;
        }

    }
}
