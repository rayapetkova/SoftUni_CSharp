int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string rate = Console.ReadLine();

double totalPrice = 0.0;

if (roomType == "room for one person")
{
    totalPrice = (days - 1) * 18.00;
}
else if (roomType == "apartment")
{
    totalPrice = (days - 1) * 25.00;

    if (days < 10)
    {
        totalPrice -= 0.3 * totalPrice;
    }
    else if (days >= 10 && days <= 15)
    {
        totalPrice -= 0.35 * totalPrice;
    }
    else 
    {
        totalPrice -= 0.5 * totalPrice;
    }
}
else if (roomType == "president apartment")
{
    totalPrice = (days - 1) * 35.00;

    if (days < 10)
    {
        totalPrice -= 0.1 * totalPrice;
    }
    else if (days >= 10 && days <= 15)
    {
        totalPrice -= 0.15 * totalPrice;
    }
    else
    {
        totalPrice -= 0.2 * totalPrice;
    }
}

if (rate == "positive")
{
    totalPrice += 0.25 * totalPrice;
}
else if (rate == "negative")
{
    totalPrice -= 0.1 * totalPrice;
}

Console.WriteLine($"{totalPrice:F2}");