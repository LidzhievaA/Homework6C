// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 *x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 =9 -> (-0,5; -0,5)

Console.Write("Введите b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());


if (k1 != k2)
{
    double coordinateX = CoordinateX(b1, k1, b2, k2);
    double coordinateY = CoordinateY(coordinateX, b1, k1);
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({coordinateX}; {coordinateY})");
}

else
if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else Console.WriteLine("Прямые параллельны и не пересекаются");



double CoordinateX(int b01, int k01, int b02, int k02)
{
    double x = (double)(b02 - b01) / (k01 - k02);
    return x;
}

double CoordinateY(double x, int b01, int k01)
{
    double y = (double)k01 * x + b01;
    return y;
}

