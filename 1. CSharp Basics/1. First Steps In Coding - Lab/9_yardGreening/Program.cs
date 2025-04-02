double squareMeters = double.Parse(Console.ReadLine());
double price = squareMeters * 7.61;

double discount = 0.18 * price;
double priceWithDiscount = price - discount;

Console.WriteLine("The final price is: " + priceWithDiscount + " lv.");
Console.WriteLine("The discount is: " + discount + " lv.");