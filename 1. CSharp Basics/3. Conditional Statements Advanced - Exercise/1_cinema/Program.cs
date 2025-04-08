string projectionType = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int cols = int.Parse(Console.ReadLine());

int allSeats = rows * cols;

double ticketPrice = 0.0;

if (projectionType == "Premiere")
{
    ticketPrice = 12.00;
}
else if (projectionType == "Normal")
{
    ticketPrice = 7.50;
}
else if (projectionType == "Discount")
{
    ticketPrice = 5.00;
}

double totalPrice = allSeats * ticketPrice;

Console.WriteLine($"{totalPrice:F2} leva");