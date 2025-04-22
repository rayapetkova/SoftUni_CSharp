int number = int.Parse(Console.ReadLine());

string finalAnswer = "";

for (int num = 1111; num <= 9999; num++)
{
    string numStr = num.ToString();
    bool isSpecial = true;

    for (int i = 0; i < numStr.Length; i++)
    {
        int digit = int.Parse(numStr[i].ToString());

        if (digit == 0 || number % digit != 0)
        {
            isSpecial = false;
            break;
        }
    }

    if (isSpecial)
    {
        finalAnswer += $"{num} ";
    }
}

Console.WriteLine(finalAnswer);