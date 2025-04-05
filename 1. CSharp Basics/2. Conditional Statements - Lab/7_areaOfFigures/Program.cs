string figure = Console.ReadLine();

if (figure == "square")
{
    double sideLength = double.Parse(Console.ReadLine());

    double area = sideLength * sideLength;
    Console.WriteLine(Math.Round(area, 3));
}
else if (figure == "rectangle")
{
    double firstSide = double.Parse(Console.ReadLine());
    double secondSide = double.Parse(Console.ReadLine());

    double area = firstSide * secondSide;
    Console.WriteLine(Math.Round(area, 3));
}
else if (figure == "circle")
{
    double radius = double.Parse(Console.ReadLine());

    double area = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine(Math.Round(area, 3));
}
else if (figure == "triangle")
{
    double sideLength = double.Parse(Console.ReadLine());
    double height = double.Parse(Console.ReadLine());

    double area = sideLength * height / 2;
    Console.WriteLine(Math.Round(area, 3));
}