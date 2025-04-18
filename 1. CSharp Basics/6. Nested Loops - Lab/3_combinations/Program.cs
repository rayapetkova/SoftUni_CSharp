int expectedResult = int.Parse(Console.ReadLine());

int combinations = 0;

for (int x1 = 0; x1 <= expectedResult; x1++)
{
    for (int x2 = 0; x2 <= expectedResult; x2++)
    {
        for (int x3 = 0; x3 <= expectedResult; x3++)
        {
            if (x1 + x2 + x3 == expectedResult)
            {
                combinations++;
            }
        }
    }
}

Console.WriteLine(combinations);