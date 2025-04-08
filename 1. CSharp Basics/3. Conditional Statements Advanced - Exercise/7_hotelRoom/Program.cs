string month = Console.ReadLine();
int nights = int.Parse(Console.ReadLine());

double studioTotalPrice = 0.0;
double apartmentTotalPrice = 0.0;

if (month == "May" || month == "October")
{
    studioTotalPrice = nights * 50;
    apartmentTotalPrice = nights * 65;

    if (nights > 14)
    {
        studioTotalPrice -= 0.3 * studioTotalPrice;
        apartmentTotalPrice -= 0.1 * apartmentTotalPrice;
    }
    else if (nights > 7)
    {
        studioTotalPrice -= 0.05 * studioTotalPrice;
    }
}
else if (month == "June" || month == "September")
{
    studioTotalPrice = nights * 75.20;
    apartmentTotalPrice = nights * 68.70;

    if (nights > 14)
    {
        studioTotalPrice -= 0.2 * studioTotalPrice;
        apartmentTotalPrice -= 0.1 * apartmentTotalPrice;
    }
}
else if (month == "July" || month == "August")
{
    studioTotalPrice = nights * 76;
    apartmentTotalPrice = nights * 77;

    if (nights > 14)
    {
        apartmentTotalPrice -= 0.1 * apartmentTotalPrice;
    }
}

Console.WriteLine($"Apartment: {apartmentTotalPrice:F2} lv.");
Console.WriteLine($"Studio: {studioTotalPrice:F2} lv.");