double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

double totalSum = 0.0;
string destination = "";
string accommodation = "";

if (budget <= 100)
{
    destination = "Bulgaria";

    switch (season)
    {
        case "summer":
            accommodation = "Camp";
            totalSum += 0.3 * budget;
            break;
        case "winter":
            accommodation = "Hotel";
            totalSum += 0.7 * budget;
            break;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";

    switch (season)
    {
        case "summer":
            accommodation = "Camp";
            totalSum += 0.4 * budget;
            break;
        case "winter":
            accommodation = "Hotel";
            totalSum += 0.8 * budget;
            break;
    }
}
else 
{
    destination = "Europe";
    accommodation = "Hotel";
    totalSum += 0.9 * budget;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{accommodation} - {totalSum:F2}");
