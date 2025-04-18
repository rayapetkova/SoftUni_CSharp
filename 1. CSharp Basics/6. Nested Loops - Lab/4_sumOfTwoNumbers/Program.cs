int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());
int magicNum = int.Parse(Console.ReadLine());

int allCombinations = 0;
bool found = false;

for (int firstNum = start; firstNum <= end; firstNum++)
{
    if (found)
    {
        break;
    }

    for (int secondNum = start; secondNum <= end; secondNum++)
    {
        allCombinations++;

        if (firstNum + secondNum == magicNum)
        {
            found = true;
            Console.WriteLine($"Combination N:{allCombinations} ({firstNum} + {secondNum} = {magicNum})");
            break;
        }
    }
}

if (!found)
{
    Console.WriteLine($"{allCombinations} combinations - neither equals {magicNum}");
}