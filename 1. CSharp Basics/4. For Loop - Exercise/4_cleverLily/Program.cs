int age = int.Parse(Console.ReadLine());
double washingMachine = double.Parse(Console.ReadLine());
int toyPrice = int.Parse(Console.ReadLine());

double savings = 0.0;
int yearMoney = 10;

for (int year = 1; year <= age; year++)
{
    if (year % 2 == 0)
    {
        savings += yearMoney - 1;
        yearMoney += 10;
    }
    else
    {
        savings += toyPrice;
    }
}

if (savings >= washingMachine)
{
    Console.WriteLine($"Yes! {(savings - washingMachine):F2}");
}
else 
{
    Console.WriteLine($"No! {(washingMachine - savings):F2}");
}