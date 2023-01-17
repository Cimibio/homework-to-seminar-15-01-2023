// По двум заданным числам проверять является ли одно квадратом другого
Console.Write("Введите первое число: ");
int N1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int N2 = int.Parse(Console.ReadLine());
if (N1 == N2 * N2) Console.WriteLine("Первое число является квадратом второго числа");
else if (N2 == N1 * N1) Console.WriteLine("Второе число является квадратом первого числа");
else Console.WriteLine("Ни первое чило не является квадратом второго, ни второе число не является квадратом первого");