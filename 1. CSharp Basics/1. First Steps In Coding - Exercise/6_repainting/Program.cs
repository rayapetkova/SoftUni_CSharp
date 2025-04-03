double nylon = double.Parse(Console.ReadLine());
double paint = double.Parse(Console.ReadLine());
double paintThinner = double.Parse(Console.ReadLine());
int hours = int.Parse(Console.ReadLine());

double nylonPrice = (nylon + 2) * 1.50;
double paintPrice = (paint + 0.10 * paint) * 14.50;
double paintThinnerPrice = paintThinner * 5.00;
double bagsPrice = 0.40;

double materialsPrice = nylonPrice + paintPrice + paintThinnerPrice + bagsPrice;
double worksmenSalary = materialsPrice * 0.30 * 8;

double finalPrice = materialsPrice + worksmenSalary;
Console.WriteLine(finalPrice);