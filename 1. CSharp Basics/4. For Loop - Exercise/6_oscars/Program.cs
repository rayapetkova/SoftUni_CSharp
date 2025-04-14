string actor = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int juries = int.Parse(Console.ReadLine());

bool nominee = false;

for (int i = 0; i < juries; i++)
{
    string jury = Console.ReadLine();
    double points = double.Parse(Console.ReadLine());

    academyPoints += (jury.Length * points) / 2;

    if (academyPoints > 1250.5)
    {
        Console.WriteLine($"Congratulations, {actor} got a nominee for leading role with {academyPoints:F1}!");
        nominee = true;
        break;
    }
}

if (!nominee)
{
    Console.WriteLine($"Sorry, {actor} you need {(1250.5 - academyPoints):F1} more!");
}