int primeSum = 0;
int nonPrimeSum = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "stop")
    {
        break;
    }

    int number = int.Parse(input);
    bool prime = true;

    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
        continue;
    }

    for (int n = 2; n <= Math.Sqrt(number); n++)
    {
        if (number % n == 0)
        {
            prime = false;
            break;
        }
    }

    if (prime)
    {
        primeSum += number;
    }
    else
    {
        nonPrimeSum += number;
    }
}

Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");