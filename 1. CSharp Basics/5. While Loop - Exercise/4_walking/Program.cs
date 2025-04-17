int goal = 10000;
int dailySteps = 0;

bool goingHome = false;

while (true)
{
    string input = Console.ReadLine();
    int steps = 0;

    if (input == "Going home")
    {
        steps = int.Parse(Console.ReadLine());
        goingHome = true;
    }
    else
    {
        steps = int.Parse(input);
    }
    
    dailySteps += steps;

    if (dailySteps >= goal)
    {
        Console.WriteLine("Goal reached! Good job!");
        Console.WriteLine($"{dailySteps - goal} steps over the goal!");
        break;
    }

    if (goingHome)
    {
        Console.WriteLine($"{goal - dailySteps} more steps to reach goal.");
        break;
    }
}