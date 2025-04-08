int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
string operation = Console.ReadLine();

double result = 0.0;

if (operation == "+")
{
    result = num1 + num2;

    if (result % 2 == 0) {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
    }
    else {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
    }
}
else if (operation == "-")
{
    result = num1 - num2;

    if (result % 2 == 0) {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
    }
    else {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
    }
}
else if (operation == "*")
{
    result = num1 * num2;

    if (result % 2 == 0) {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - even");
    }
    else {
        Console.WriteLine($"{num1} {operation} {num2} = {result} - odd");
    }
}
else if (operation == "/")
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else
    {
        result = num1 / (double)num2;
        Console.WriteLine($"{num1} {operation} {num2} = {result:F2}");
    }
}
else if (operation == "%")
{
    if (num2 == 0)
    {
        Console.WriteLine($"Cannot divide {num1} by zero");
    }
    else {
        result = num1 % (double)num2;
        Console.WriteLine($"{num1} {operation} {num2} = {result}");
    }
    
}
