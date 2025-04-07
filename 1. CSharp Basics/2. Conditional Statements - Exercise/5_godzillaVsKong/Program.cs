double budget = double.Parse(Console.ReadLine());
int backgroundActors = int.Parse(Console.ReadLine());
double actorClothingPrice = double.Parse(Console.ReadLine());

double decor = 0.1 * budget;
double clothingFinalPrice = backgroundActors * actorClothingPrice;

if (backgroundActors > 150)
{
    clothingFinalPrice -= 0.1 * clothingFinalPrice;
}

double finalPrice = clothingFinalPrice + decor;

if (finalPrice > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {(finalPrice - budget):F2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {(budget - finalPrice):F2} leva left.");
}
