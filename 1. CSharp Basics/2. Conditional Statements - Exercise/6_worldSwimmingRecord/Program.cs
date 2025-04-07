double record = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timeForOneMeter = double.Parse(Console.ReadLine());

double distanceTime = distance * timeForOneMeter;

double countFifteenMinutesTimes = Math.Floor(distance / 15);
double timeDelay = countFifteenMinutesTimes * 12.5;

double finalTime = distanceTime + timeDelay;

if (finalTime < record)
{
    Console.WriteLine($" Yes, he succeeded! The new world record is {finalTime:F2} seconds.");
}
else 
{
    Console.WriteLine($"No, he failed! He was {(finalTime - record):F2} seconds slower.");
}