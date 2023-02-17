

Console.WriteLine("Введите координаты Х");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты Y");
int y = Convert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находится в первой координатной четверти");
}

else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}

else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}

else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвёртой координатной четверти");
}

else
{
    Console.WriteLine("Невозможно определить координатную четверть");
}