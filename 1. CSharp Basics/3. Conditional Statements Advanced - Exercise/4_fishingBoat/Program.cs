int budget = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
int fishmen = int.Parse(Console.ReadLine());

double boatPrice = 0.0;

switch (season)
{
    case "Spring":
        boatPrice = 3000;
        break;
    case "Summer":
    case "Autumn":
        boatPrice = 4200;
        break;
    case "Winter":
        boatPrice = 2600;
        break;
}

if (fishmen <= 6)
{
    boatPrice -= 0.1 * boatPrice;
}
else if (fishmen <= 11)
{
    boatPrice -= 0.15 * boatPrice;
}
else
{
    boatPrice -= 0.25 * boatPrice;
}

if (fishmen % 2 == 0 && season != "Autumn")
{
    boatPrice -= 0.05 * boatPrice;
}

if (budget >= boatPrice)
{
    Console.WriteLine($"Yes! You have {(budget - boatPrice):F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money! You need {(boatPrice - budget):F2} leva.");
}