int biggestNum = int.MinValue;

string input = Console.ReadLine();

while (input != "Stop")
{
    int number = int.Parse(input);

    if (number > biggestNum)
    {
        biggestNum = number;
    }

    input = Console.ReadLine();
}

Console.WriteLine(biggestNum);