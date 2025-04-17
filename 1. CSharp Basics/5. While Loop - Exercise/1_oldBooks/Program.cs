string favouriteBook = Console.ReadLine();

int allBooks = 0;

string input = Console.ReadLine();

while (input != favouriteBook)
{

    if (input == "No More Books")
    {
        Console.WriteLine("The book you search is not here!");
        Console.WriteLine($"You checked {allBooks} books.");
        break;
    }

    input = Console.ReadLine();

    allBooks += 1;
}

if (input == favouriteBook)
{
    Console.WriteLine($"You checked {allBooks} books and found it.");
}