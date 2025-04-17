int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());

int space = width * length * height;

int cartonsSpace = 0;

while (true)
{
    string input = Console.ReadLine();

    if (input == "Done")
    {
        Console.WriteLine($"{space - cartonsSpace} Cubic meters left.");
        break;
    }

    int cartonsCount = int.Parse(input);
    cartonsSpace += cartonsCount;

    if (cartonsSpace >= space)
    {
        Console.WriteLine($"No more free space! You need {cartonsSpace - space} Cubic meters more.");
        break;
    }
}