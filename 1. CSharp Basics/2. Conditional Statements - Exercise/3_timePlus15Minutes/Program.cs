﻿int hours = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

if (minutes >= 45)
{
    hours += 1;
    minutes = (minutes + 15) % 60;
}
else
{
    minutes += 15;
}


if (hours == 24) 
{
    hours = 0;
}

if (minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}