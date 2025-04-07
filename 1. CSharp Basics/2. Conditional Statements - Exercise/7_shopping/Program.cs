double budget = double.Parse(Console.ReadLine());
int videoCards = int.Parse(Console.ReadLine());
int processors = int.Parse(Console.ReadLine());
int ram = int.Parse(Console.ReadLine());

double videoCardsPrice = videoCards * 250;
double processorsPrice = processors * (0.35 * videoCardsPrice);
double ramPrice = ram * (0.1 * videoCardsPrice);

double finalPrice = videoCardsPrice + processorsPrice + ramPrice;

if (videoCards > processors)
{
    finalPrice -= 0.15 * finalPrice;
}

if (finalPrice <= budget)
{
    Console.WriteLine($"You have {(budget - finalPrice):F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {(finalPrice - budget):F2} leva more!");
}