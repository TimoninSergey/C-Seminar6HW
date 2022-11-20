//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

/*
По правилу Крамера:
y = k1*x + b1
y = k2*x + b2

k1*x - y = - b1
k2*x - y = - b2

X:
-b1 -1
-b2 -1

Y:
k1 -b1
k2 -b2

deltaSystem = k1 * (-1) - (-1) * k2 = -k1 + k2 = k2 - k1
deltaX = -b1 *(-1) - (-1)*(-b2) = b1 - b2
deltaY = k1*(-b2) - (-b1)*k2 = k2*b1 - k1*b2
*/

Console.WriteLine("Введите k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2");
double b2 = Convert.ToInt32(Console.ReadLine());

double[,] system = new double[,]
{
{k1, b1},
{k2, b2},
};

StraightCrossingFinder(system);

void StraightCrossingFinder (double[,] array)
{
    double deltaSystem = array[0,1] - array[0,0];
    if (deltaSystem == 0) Console.WriteLine("Прямые параллельны");
    else
    { 
        double deltaX = array[1,0] - array[1,1];
        double deltaY = array[0,1]*array[1,0] - array[0,0]*array[1,1];
        double x = deltaX / deltaSystem;
        double y = deltaY / deltaSystem;
        Console.WriteLine($"Прямые пересекутся в точке с координатами ({x}, {y})");
    }
}

