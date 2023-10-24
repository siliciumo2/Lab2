Console.WriteLine("Введите a,b,c");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int minus = 0;
    if (a < 0)
{
        minus++;
}
    if (b < 0)
{
    minus++;
}
    if (c < 0)
{
    minus++;
}
Console.WriteLine($"Отрицательные числа - {minus}");