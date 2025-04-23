string day = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int price = 0;
bool isError = false;

if (age >= 0 && age <= 18)
{
    if (day == "Weekday")
    {
        price = 12;
    }
    else if (day == "Weekend")
    {
        price = 15;
    }
    else if (day == "Holiday")
    {
        price = 5;
    }
    else
    {
        isError = true;
    }
}
else if (age > 18 && age <= 64)
{
    if (day == "Weekday")
    {
        price = 18;
    }
    else if (day == "Weekend")
    {
        price = 20;
    }
    else if (day == "Holiday")
    {
        price = 12;
    }
    else
    {
        isError = true;
    }
}
else if (age > 64 && age <= 122)
{
    if (day == "Weekday")
    {
        price = 12;
    }
    else if (day == "Weekend")
    {
        price = 15;
    }
    else if (day == "Holiday")
    {
        price = 10;
    }
    else
    {
        isError = true;
    }
}
else
{
    isError = true;
}

if (!isError)
{
    Console.WriteLine($"{price}$");
}
else
{
    Console.WriteLine("Error!");
}