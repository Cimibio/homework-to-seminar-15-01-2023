// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.Write("Введите день недели: ");
int N = int.Parse(Console.ReadLine());
if ( N == 6 | N == 7)
{
    Console.WriteLine("Это выходной день!");
}
else if (N <= 0 | N >= 8)
{
    Console.WriteLine("Такого дня в неделе нет!");
}
else
{
    Console.WriteLine("Это обычный, будний день!");
}