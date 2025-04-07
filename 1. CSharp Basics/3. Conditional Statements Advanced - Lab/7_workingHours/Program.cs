int time = int.Parse(Console.ReadLine());
string day = Console.ReadLine();

string[] workingDays = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

if (workingDays.Contains(day) && time >= 10 && time <= 18)
{
    Console.WriteLine("open");
}
else
{
    Console.WriteLine("closed");
}