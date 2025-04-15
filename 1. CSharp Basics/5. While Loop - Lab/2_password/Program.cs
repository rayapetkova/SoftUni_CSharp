string username = Console.ReadLine();
string password = Console.ReadLine();

string guess = Console.ReadLine();

while (guess != password)
{
    guess = Console.ReadLine();
}

Console.WriteLine($"Welcome {username}!");