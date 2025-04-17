int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int allPieces = width * length;

bool stopped = false;

while (allPieces > 0)
{
    string input = Console.ReadLine();

    if (input == "STOP")
    {
        Console.WriteLine($"{allPieces} pieces are left.");
        stopped = true;
        break;
    }

    int pieces = int.Parse(input);
    allPieces -= pieces;
}

if (!stopped)
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(allPieces)} pieces more.");
}