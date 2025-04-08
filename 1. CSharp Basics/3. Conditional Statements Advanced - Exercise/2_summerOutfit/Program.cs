int temperature = int.Parse(Console.ReadLine());
string time = Console.ReadLine();

string outfit = "";
string shoes = "";

if (temperature >= 10 && temperature <= 18)
{
    if (time == "Afternoon" || time == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (time == "Morning")
    {
        outfit = "Sweatshirt";
        shoes = "Sneakers";
    }
}
else if (temperature > 18 && temperature <= 24)
{
    if (time == "Morning" || time == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
    else if (time == "Afternoon")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
}
else if (temperature >= 25)
{
    if (time == "Morning")
    {
        outfit = "T-Shirt";
        shoes = "Sandals";
    }
    else if (time == "Afternoon")
    {
        outfit = "Swim Suit";
        shoes = "Barefoot";
    }
    else if (time == "Evening")
    {
        outfit = "Shirt";
        shoes = "Moccasins";
    }
}

Console.WriteLine($"It's {temperature} degrees, get your {outfit} and {shoes}.");