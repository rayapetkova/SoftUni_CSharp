int jury = int.Parse(Console.ReadLine());

int allPresentationsRatesCount = 0;
double totalRates = 0;

while (true)
{
    string presentation = Console.ReadLine();

    if (presentation == "Finish")
    {
        break;
    }

    double allRates = 0;

    for (int i = 0; i < jury; i++)
    {
        double rate = double.Parse(Console.ReadLine());

        allRates += rate;
        totalRates += rate;
        allPresentationsRatesCount++;
    }

    Console.WriteLine($"{presentation} - {(allRates / jury):F2}.");
}

Console.WriteLine($"Student's final assessment is {(totalRates / allPresentationsRatesCount):F2}.");