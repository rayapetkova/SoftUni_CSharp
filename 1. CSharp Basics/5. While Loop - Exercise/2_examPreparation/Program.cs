int badGradesCount = int.Parse(Console.ReadLine());

int gradesSum = 0;
int gradesCount = 0;
int badGradesTotal = 0;
string lastProblem = "";

while (true)
{
    string task = Console.ReadLine();

    if (task == "Enough")
    {
        Console.WriteLine($"Average score: {((double)gradesSum / gradesCount):F2}");
        Console.WriteLine($"Number of problems: {gradesCount}");
        Console.WriteLine($"Last problem: {lastProblem}");
        break;
    }

    lastProblem = task;

    int grade = int.Parse(Console.ReadLine());

    if (grade <= 4)
    {
        badGradesTotal += 1;
    }

    if (badGradesTotal == badGradesCount)
    {
        Console.WriteLine($"You need a break, {badGradesTotal} poor grades.");
        break;
    }

    gradesSum += grade;
    gradesCount += 1;

}