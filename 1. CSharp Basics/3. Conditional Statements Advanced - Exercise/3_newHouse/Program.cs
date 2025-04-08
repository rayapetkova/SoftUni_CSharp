string flowers = Console.ReadLine();
int numberFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double finalPrice = 0.0;

if (flowers == "Roses")
{
    finalPrice = numberFlowers * 5;

    if (numberFlowers > 80)
    {
        finalPrice -= 0.1 * finalPrice;
    }
}
else if (flowers == "Dahlias")
{
    finalPrice = numberFlowers * 3.80;

    if (numberFlowers > 90)
    {
        finalPrice -= 0.15 * finalPrice;
    }
}
else if (flowers == "Tulips")
{
    finalPrice = numberFlowers * 2.80;

    if (numberFlowers > 80)
    {
        finalPrice -= 0.15 * finalPrice;
    }
}
else if (flowers == "Narcissus")
{
    finalPrice = numberFlowers * 3;

    if (numberFlowers < 120)
    {
        finalPrice += 0.15 * finalPrice;
    }
}
else if (flowers == "Gladiolus")
{
    finalPrice = numberFlowers * 2.50;

    if (numberFlowers < 80)
    {
        finalPrice += 0.2 * finalPrice;
    }
}


if (budget >= finalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {flowers} and {(budget - finalPrice):F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {(finalPrice - budget):F2} leva more.");
}