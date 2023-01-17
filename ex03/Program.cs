// Задать номер четверти, показать диапазоны для возможных координат
Console.Write("Введите номер четверти: ");
int N = int.Parse(Console.ReadLine());
if (N == 1)
{
    Console.WriteLine("В первой четверти X > 0, Y > 0");
}
else if ( N == 2)
{
    Console.WriteLine("Во второй четверти X < 0, Y > 0");
}
else if ( N == 3)
{
    Console.WriteLine("В третьей четверти X < 0, Y < 0");
}
else if ( N == 4)
{
    Console.WriteLine("В четвертой четверти X > 0, Y < 0");
}
else
{
    Console.WriteLine("Номер четверти может быть 1, 2, 3 или 4!");
}