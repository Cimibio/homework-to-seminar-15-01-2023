// Найти расстояние между точками в пространстве 2D/3D
Console.Write("Для выбора двумерного пространства введите 2, для трехмерного - 3, либо нажмите 1 для случайной генерации точек и пространств: ");
int N = int.Parse(Console.ReadLine());
double D2calc(int x1, int y1, int x2, int y2)
{
    double D2res = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1) * (y2 - y1)));
    return D2res;
}

double D3calc(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double D3res = Math.Sqrt(((x2 - x1)*(x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
    return D3res;
}

if ( N == 1) 
{
    int space = new Random().Next(1,3);
    if (space == 1) //двумерное пространство
    {
        int x1 = new Random().Next(-999, 999);
        int x2 = new Random().Next(-999, 999);
        int y1 = new Random().Next(-999, 999);
        int y2 = new Random().Next(-999, 999);
        Console.WriteLine("Выбрано двумерное пространство");
        Console.WriteLine("Расстояние между точкой А, с координатами: " + x1 + ", " + y1 + " и точкой B, с координатами: " + x2 + ", " + y2 + " равно: " + D2calc(x1,y1,x2,y2));
    }
    else if (space == 2)           //трехмерное пространство
    {
        int x1 = new Random().Next(-999, 999);
        int x2 = new Random().Next(-999, 999);
        int y1 = new Random().Next(-999, 999);
        int y2 = new Random().Next(-999, 999);
        int z1 = new Random().Next(-999, 999);
        int z2 = new Random().Next(-999, 999);
        Console.WriteLine("Выбрано трехмерное пространство");
        Console.WriteLine("Расстояние между точкой А, с координатами: " + x1 + ", " + y1 + ", " + z1 + " и точкой B, с координатами: " + x2 + ", " + y2 + ", " + z2 + " равно: " + D3calc(x1,y1,z1,x2,y2,z2));
    }
    else
    {
        Console.WriteLine("значение переменной space - " + space);
    }
}
else if (N == 2)
{
    Console.WriteLine("Выбрано двумерное пространство!");
    Console.WriteLine("Введите координаты точки А");
    Console.Write("Введите X1: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("Введите Y1: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B");
    Console.Write("Введите X2: ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("Введите Y2: ");
    int y2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Расстояние между точкой А, с координатами: " + x1 + ", " + y1 + " и точкой B, с координатами: " + x2 + ", " + y2 + " равно: " + D2calc(x1,y1,x2,y2));
}
else if (N == 3)
{
    Console.WriteLine("Выбрано трехмерное пространство!");
    Console.WriteLine("Введите координаты точки А");
    Console.Write("Введите X1: ");
    int x1 = int.Parse(Console.ReadLine());
    Console.Write("Введите Y1: ");
    int y1 = int.Parse(Console.ReadLine());
    Console.Write("Введите Z1: ");
    int z1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите координаты точки B");
    Console.Write("Введите X2: ");
    int x2 = int.Parse(Console.ReadLine());
    Console.Write("Введите Y2: ");
    int y2 = int.Parse(Console.ReadLine());
    Console.Write("Введите Z2: ");
    int z2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Расстояние между точкой А, с координатами: " + x1 + ", " + y1 + ", " + z1 + " и точкой B, с координатами: " + x2 + ", " + y2 + ", " + z2 + " равно: " + D3calc(x1,y1,z1,x2,y2,z2));
}
else 
{
    Console.WriteLine("Необходимо ввести 1, 2 или 3");
}
