double deposit = double.Parse(Console.ReadLine());
int months = int.Parse(Console.ReadLine());
double percents = double.Parse(Console.ReadLine());

double interest = deposit * percents / 100;
double yearInterest = interest / 12;

double finalSum = deposit + months * yearInterest;
Console.WriteLine(finalSum);
