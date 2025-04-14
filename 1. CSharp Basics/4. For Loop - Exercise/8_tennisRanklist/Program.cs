int competitions = int.Parse(Console.ReadLine());
int startPoints = int.Parse(Console.ReadLine());

int points = 0;
int winnerCompetitions = 0;

for (int c = 0; c < competitions; c++)
{
    string result = Console.ReadLine();

    if (result == "W")
    {
        points += 2000;
        winnerCompetitions += 1;
    }
    else if (result == "F")
    {
        points += 1200;
    }
    else if (result == "SF")
    {
        points += 720;
    }
}

int allPoints = startPoints + points;
double averagePoints = (double)points / competitions;
double winnerPercents = ((double)winnerCompetitions / competitions) * 100;

Console.WriteLine($"Final points: {allPoints}");
Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
Console.WriteLine($"{winnerPercents:F2}%");