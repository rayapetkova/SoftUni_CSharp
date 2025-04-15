string name = Console.ReadLine();

int timesFailed = 0;
int allGrades = 0;
double gradesSum = 0;

while (timesFailed <= 1 && allGrades <= 12)
{
    double grade = double.Parse(Console.ReadLine());

    if (grade < 4)
    {
        timesFailed += 1;
    }

    allGrades += 1;
    gradesSum += grade;
}



if (timesFailed > 1)
{
    Console.WriteLine($"{name} has been excluded at {allGrades - 1} grade");
}
else
{

    Console.WriteLine($"{name} graduated. Average grade: {(gradesSum / allGrades):F2}");
}