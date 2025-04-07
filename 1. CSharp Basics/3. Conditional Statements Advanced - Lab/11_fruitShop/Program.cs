string product = Console.ReadLine();
string day = Console.ReadLine();
double quantity = double.Parse(Console.ReadLine());

string[] weekdays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
string[] weekend = {"Saturday", "Sunday"};

double banana = 0.0;
double apple = 0.0;
double orange = 0.0;
double grapefruit = 0.0;
double kiwi = 0.0;
double pineapple = 0.0;
double grapes = 0.0;

string error = "";

if (weekdays.Contains(day))
{
    banana = 2.50;
    apple = 1.20;
    orange = 0.85;
    grapefruit = 1.45;
    kiwi = 2.70;
    pineapple = 5.50;
    grapes = 3.85;
}
else if (weekend.Contains(day))
{
    banana = 2.70;
    apple = 1.25;
    orange = 0.90;
    grapefruit = 1.60;
    kiwi = 3.00;
    pineapple = 5.60;
    grapes = 4.20;
}
else 
{
    error = "error";
}

double finalPrice = 0.0;

switch (product)
{
    case "banana":
        finalPrice = banana * quantity;
        break;
    case "apple":
        finalPrice = apple * quantity;
        break;
    case "orange":
        finalPrice = orange * quantity;
        break;
    case "grapefruit":
        finalPrice = grapefruit * quantity;
        break;
    case "kiwi":
        finalPrice = kiwi * quantity;
        break;
    case "pineapple":
        finalPrice = pineapple * quantity;
        break;
    case "grapes":
        finalPrice = grapes * quantity;
        break;
    default:
        error = "error";
        break;
}

if (error == "")
{
    Console.WriteLine($"{finalPrice:F2}");
}
else
{
    Console.WriteLine(error);
}