int number = int.Parse(Console.ReadLine());

int numsOnRow = 1;
int currentNum = 1;
bool isBigger = false;

while (true)
{
    string row = "";

    for (int n = currentNum; n < currentNum + numsOnRow; n++)
    {
        if (n > number)
        {
            isBigger = true;
            break;
        }
        row += $"{n} ";
    }

    currentNum += numsOnRow;
    numsOnRow++;

    Console.WriteLine(row);

    if (isBigger)
    {
        break;
    }
}