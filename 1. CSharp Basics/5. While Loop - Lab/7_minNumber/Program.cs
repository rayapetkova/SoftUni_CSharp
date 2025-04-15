int smallestNum = int.MaxValue;

string input = Console.ReadLine();

while (input != "Stop")
{
    int number = int.Parse(input);

    if (number < smallestNum)
    {
        smallestNum = number;
    }

    input = Console.ReadLine();
}

Console.WriteLine(smallestNum);