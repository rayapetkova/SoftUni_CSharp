int people = int.Parse(Console.ReadLine());
string group = Console.ReadLine();
string day = Console.ReadLine();

double totalPrice = 0.0;


if (day == "Friday")
{
    if (group == "Students")
    {
        totalPrice = people * 8.45;

        if (people >= 30)
        {
            totalPrice -= 0.15 * totalPrice;
        }
    }
    else if (group == "Business")
    {
        if (people >= 100)
        {
            people -= 10;
        }

        totalPrice = people * 10.90;
    }
    else if (group == "Regular")
    {
        totalPrice = people * 15;

        if (people >= 10 && people <= 20)
        {
            totalPrice -= 0.05 * totalPrice;
        }
    }
}
else if (day == "Saturday")
{
    if (group == "Students")
    {
        totalPrice = people * 9.80;

        if (people >= 30)
        {
            totalPrice -= 0.15 * totalPrice;
        }
    }
    else if (group == "Business")
    {
        if (people >= 100)
        {
            people -= 10;
        }
        
        totalPrice = people * 15.60;
    }
    else if (group == "Regular")
    {
        totalPrice = people * 20;

        if (people >= 10 && people <= 20)
        {
            totalPrice -= 0.05 * totalPrice;
        }
    }
}
else if (day == "Sunday")
{
    if (group == "Students")
    {
        totalPrice = people * 10.46;

        if (people >= 30)
        {
            totalPrice -= 0.15 * totalPrice;
        }
    }
    else if (group == "Business")
    {
        if (people >= 100)
        {
            people -= 10;
        }
        
        totalPrice = people * 16;
    }
    else if (group == "Regular")
    {
        totalPrice = people * 22.50;

        if (people >= 10 && people <= 20)
        {
            totalPrice -= 0.05 * totalPrice;
        }
    }
}

Console.WriteLine($"Total price: {totalPrice:F2}");