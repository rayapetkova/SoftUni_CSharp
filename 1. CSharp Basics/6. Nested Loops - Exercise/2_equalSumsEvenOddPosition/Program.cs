int firstNum = int.Parse(Console.ReadLine());
int secondNum = int.Parse(Console.ReadLine());

string finalAnswer = "";

for (int num = firstNum; num <= secondNum; num++)
{
    string number = num.ToString();

    int evenSum = 0;
    int oddSum = 0;

    for (int i = 0; i < number.Length; i++)
    {
        int n = int.Parse(number[i].ToString());

        if (i % 2 == 0)
        {
            oddSum += n;
        }
        else
        {
            evenSum += n;
        }
    }

    if (evenSum == oddSum)
    {
        finalAnswer += $"{num} ";
    }
}

Console.WriteLine(finalAnswer);