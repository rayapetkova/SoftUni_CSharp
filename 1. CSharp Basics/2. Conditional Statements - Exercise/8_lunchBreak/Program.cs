string seriesName = Console.ReadLine();
int episodeDuration = int.Parse(Console.ReadLine());
int breakDuration = int.Parse(Console.ReadLine());

double lunch = breakDuration / 8.0;
double rest = breakDuration / 4.0;

double leftTime = breakDuration - lunch - rest;

if (leftTime >= episodeDuration)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(leftTime - episodeDuration)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(episodeDuration - leftTime)} more minutes.");
}