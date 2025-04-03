int chickenMenus = int.Parse(Console.ReadLine());
int fishMenus = int.Parse(Console.ReadLine());
int vegetarianMenus = int.Parse(Console.ReadLine());

double menusPrice = chickenMenus * 10.35 + fishMenus * 12.40 + vegetarianMenus * 8.15;
double dessertPrice = menusPrice * 0.20;
double delivery = 2.50;

double finalPrice = menusPrice + dessertPrice + delivery;
Console.WriteLine(finalPrice);