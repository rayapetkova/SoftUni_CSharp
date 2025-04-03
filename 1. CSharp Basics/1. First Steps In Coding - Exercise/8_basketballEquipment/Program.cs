int yearlyFee = int.Parse(Console.ReadLine());

double shoes = yearlyFee - 0.40 * yearlyFee;
double outfit = shoes - 0.20 * shoes;
double ball = outfit / 4;
double accessories = ball / 5;

double finalPrice = yearlyFee + shoes + outfit + ball + accessories;
Console.WriteLine(finalPrice);