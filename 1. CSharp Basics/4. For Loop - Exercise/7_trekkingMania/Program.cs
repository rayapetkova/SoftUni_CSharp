int groups = int.Parse(Console.ReadLine());

int allPeople = 0;

int musalaPeople = 0;
int montBlancPeople = 0;
int kilimanjaroPeople = 0;
int k2People = 0;
int everestPeople = 0;

for (int group = 0; group < groups; group++)
{
    int people = int.Parse(Console.ReadLine());
    allPeople += people;

    if (people <= 5)
    {
        musalaPeople += people;
    }
    else if (people <= 12)
    {
        montBlancPeople += people;
    }
    else if (people <= 25)
    {
        kilimanjaroPeople += people;
    }
    else if (people <= 40)
    {
        k2People += people;
    }
    else
    {
        everestPeople += people;
    }
}

double musalaPercents = (double)musalaPeople / (double)allPeople * 100;
double montBlancPercents = (double)montBlancPeople / (double)allPeople * 100;
double kilimanjaroPercents = (double)kilimanjaroPeople / (double)allPeople * 100;
double k2Percents = (double)k2People / (double)allPeople * 100;
double everestPercents = (double)everestPeople / (double)allPeople * 100;

Console.WriteLine($"{musalaPercents:F2}%");
Console.WriteLine($"{montBlancPercents:F2}%");
Console.WriteLine($"{kilimanjaroPercents:F2}%");
Console.WriteLine($"{k2Percents:F2}%");
Console.WriteLine($"{everestPercents:F2}%");
