string text = Console.ReadLine();

Dictionary<string, int> vowels = new Dictionary<string, int>
{
    {"a", 1},
    {"e", 2},
    {"i", 3},
    {"o", 4},
    {"u", 5}
};

int totalSum = 0;

for (int i = 0; i < text.Length; i++)
{
    string character = text[i].ToString();

    if (vowels.ContainsKey(character))
    {
        totalSum += vowels[character];
    }
}

Console.WriteLine(totalSum);