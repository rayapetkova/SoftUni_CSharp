int examHour = int.Parse(Console.ReadLine());
int examMinutes = int.Parse(Console.ReadLine());
int arriveHour = int.Parse(Console.ReadLine());
int arriveMinutes = int.Parse(Console.ReadLine());

int examSumMinutes = examHour * 60 + examMinutes;
int arriveSumMinutes = arriveHour * 60 + arriveMinutes;
int difference = examSumMinutes - arriveSumMinutes;

bool isLate = false;

if (arriveHour < examHour)
{   
    if (difference > 30) {
        Console.WriteLine("Early");
    }
    else if (difference >= 0 && difference <= 30)
    {
        Console.WriteLine("On time");
    }
    else
    {
        Console.WriteLine("Late");
        isLate = true;
    }
}
else if (arriveHour == examHour)
{
    if (arriveMinutes > examMinutes)
    {
        Console.WriteLine("Late");
        isLate = true;
    }
    else if (arriveMinutes <= 30)
    {
        Console.WriteLine("On time");
    }
    else 
    {
        Console.WriteLine("Early");
    }
}
else
{
    Console.WriteLine("Late");
    isLate = true;
}

if (isLate)
{
    if (Math.Abs(difference) < 60)
    {
        Console.WriteLine($"{Math.Abs(difference)} minutes after the start");
    }
    else 
    {
        int hours = Math.Abs(difference) / 60;
        int mins = Math.Abs(difference) % 60;

        Console.WriteLine($"{hours}:{mins:D2} hours after the start");
    }
}

if (!isLate && !(examHour == arriveHour && examMinutes == arriveMinutes))
{
    if (Math.Abs(difference) < 60)
    {
        Console.WriteLine($"{Math.Abs(difference)} minutes before the start");
    }
    else 
    {
        int hours = Math.Abs(difference) / 60;
        int mins = Math.Abs(difference) % 60;

        Console.WriteLine($"{hours}:{mins:D2} hours before the start");
    }
}
