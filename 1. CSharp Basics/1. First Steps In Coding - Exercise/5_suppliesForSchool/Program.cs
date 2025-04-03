int numPens = int.Parse(Console.ReadLine());
int numMarkers = int.Parse(Console.ReadLine());
int whiteboartCleaningLiters = int.Parse(Console.ReadLine());
int discount = int.Parse(Console.ReadLine());

double pensPrice = numPens * 5.80;
double markersPrice = numMarkers * 7.20;
double cleaningPrice = whiteboartCleaningLiters * 1.20;

double finalPrice = pensPrice + markersPrice + cleaningPrice;
double finalPriceWithDiscount = finalPrice - finalPrice * discount / 100;
Console.WriteLine(finalPriceWithDiscount);