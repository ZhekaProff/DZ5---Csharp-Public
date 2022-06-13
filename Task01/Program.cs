// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, 
// b1 k1 и b2 и k2 заданы. 

Console.Clear();
Console.Write("Введите коэффициент k1: ");
int k1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите коэффициент b1: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите коэффициент k2: ");
int k2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите коэффициент b2: ");
int b2 = int.Parse(Console.ReadLine() ?? "0");
int x = 0;
int y = 0;
// Составим систему 2-х уравнений для поиска точки пересечения прямых:
// y = k1 * x + b1, 
// y = k2 * x + b2, 
// Вычтем из первого уравнения второе:
// y - y = k1 * x + b1 - k2 * x - b2
// 0 = x * (k1 - k2) + b1 - b2
// x = (b2 - b1) / (k1 - k2)
if (k1 == k2) Console.WriteLine("При данных коэффициентах k1 и k2 прямые не пересекаются!");
else 
{
    x = (b2 - b1) / (k1 - k2);
    y = k2 * x + b2;
    Console.WriteLine($"Точка пересечения заданных прямых имеет координаты x = {x}, y = {y}");
}
