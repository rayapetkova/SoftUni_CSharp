string city = Console.ReadLine();
double salesVolume = double.Parse(Console.ReadLine());

bool error = false;

double percents = 0.0;

if (salesVolume >= 0 && salesVolume <= 500)
{
    switch (city)
    {
        case "Sofia":
            percents = 0.05;
            break;
        case "Varna":
            percents = 0.045;
            break;
        case "Plovdiv":
            percents = 0.055;
            break;
        default:
            error = true;
            break;
    }
}
else if (salesVolume > 500 && salesVolume <= 1000)
{
    switch (city)
    {
        case "Sofia":
            percents = 0.07;
            break;
        case "Varna":
            percents = 0.075;
            break;
        case "Plovdiv":
            percents = 0.08;
            break;
        default:
            error = true;
            break;
    }
}
else if (salesVolume > 1000 && salesVolume <= 10000)
{
    switch (city)
    {
        case "Sofia":
            percents = 0.08;
            break;
        case "Varna":
            percents = 0.1;
            break;
        case "Plovdiv":
            percents = 0.12;
            break;
        default:
            error = true;
            break;
    }
}
else if (salesVolume > 10000)
{
    switch (city)
    {
        case "Sofia":
            percents = 0.12;
            break;
        case "Varna":
            percents = 0.13;
            break;
        case "Plovdiv":
            percents = 0.145;
            break;
        default:
            error = true;
            break;
    }
}
else {
    error = true;
}

double commissions = percents * salesVolume;

if (error)
{
    Console.WriteLine("error");
}
else
{
    Console.WriteLine($"{commissions:F2}");
}