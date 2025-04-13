int nums = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

for (int i = 0; i < nums; i++)
{
    int num1 = int.Parse(Console.ReadLine());
    leftSum += num1;
}

for (int j = 0; j < nums; j++)
{
    int num2 = int.Parse(Console.ReadLine());
    rightSum += num2;
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    int difference = Math.Abs(leftSum - rightSum);
    Console.WriteLine($"No, diff = {difference}");
}