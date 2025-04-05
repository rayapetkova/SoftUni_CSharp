using System.Data.Common;

double tripPrice = double.Parse(Console.ReadLine());
int puzzels = int.Parse(Console.ReadLine());
int dolls = int.Parse(Console.ReadLine());
int bears = int.Parse(Console.ReadLine());
int minions = int.Parse(Console.ReadLine());
int trucks = int.Parse(Console.ReadLine());

int order = puzzels + dolls + bears + minions + trucks;

double finalPrice = puzzels * 2.60 + dolls * 3 + bears * 4.10 + minions * 8.20 + trucks * 2;

if (order >= 50)
{
    finalPrice -= 0.25 * finalPrice;
}

finalPrice -= 0.1 * finalPrice;

if (finalPrice >= tripPrice)
{
    Console.WriteLine($"Yes! {(finalPrice - tripPrice):F2} lv left.");
}
else 
{
    Console.WriteLine($"Not enough money! {(tripPrice - finalPrice):F2} lv needed.");
}