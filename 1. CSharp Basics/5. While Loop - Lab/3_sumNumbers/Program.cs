int firstNum = int.Parse(Console.ReadLine());

int number = int.Parse(Console.ReadLine());
int sum = number;

while (sum < firstNum)
{
    number = int.Parse(Console.ReadLine());
    sum += number;
}

Console.WriteLine(sum);