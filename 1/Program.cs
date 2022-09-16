// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

void IntersectionPoint(int k1, int k2, int b1, int b2)
{
    if (k1 != k2)
    {
        Console.WriteLine($"Координаты точки пересечения: [{(b2 - b1) / (k1 - k2)},{k1 * ((b2 - b1) / (k1 - k2)) + b1}]");
    }
    else
    {
        Console.WriteLine("Прямые не перечекаются или совпадают");
    }

}

Console.WriteLine("Введите значения для прямой y=k1*x+b1 :");

Console.WriteLine("k1:");
int k1  = int.Parse(Console.ReadLine());

Console.WriteLine("b1:");
int b1  = int.Parse(Console.ReadLine());

Console.WriteLine("Введите значения для прямой y=k2*x+b2 :");

Console.WriteLine("k2:");
int k2  = int.Parse(Console.ReadLine());

Console.WriteLine("b2:");
int b2  = int.Parse(Console.ReadLine());

IntersectionPoint(k1,k2,b1,b2);