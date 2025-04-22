int allTickets = 0;
int allStudent = 0;
int allStandard = 0;
int allKid = 0;

while (true)
{
    string movie = Console.ReadLine();

    if (movie == "Finish")
    {
        break;
    }

    int seats = int.Parse(Console.ReadLine());
    int totalTickets = 0;

    while (true)
    {
        string typeTicket = Console.ReadLine();

        if (typeTicket == "End")
        {
            break;
        }
        else if (typeTicket == "student")
        {
            allStudent++;
            totalTickets++;
        }
        else if (typeTicket == "standard")
        {
            allStandard++;
            totalTickets++;
        }
        else if (typeTicket == "kid")
        {
            allKid++;
            totalTickets++;
        }

        if (totalTickets >= seats)
        {
            break;
        }
    }

    allTickets += totalTickets;

    double percentsFull = ((double)totalTickets * 100) / seats;
    Console.WriteLine($"{movie} - {percentsFull:F2}% full.");
    
}

double studentPercents = ((double)allStudent * 100) / allTickets;
double standardPercents = ((double)allStandard * 100) / allTickets;
double kidPercents = ((double)allKid * 100) / allTickets;

Console.WriteLine($"Total tickets: {allTickets}");
Console.WriteLine($"{studentPercents:F2}% student tickets.");
Console.WriteLine($"{standardPercents:F2}% standard tickets.");
Console.WriteLine($"{kidPercents:F2}% kids tickets.");