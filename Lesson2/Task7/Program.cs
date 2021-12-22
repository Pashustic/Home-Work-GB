// a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
// б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
// Павел Щербак
void RecursMetodNumbs(int a, int b)
{
    if (a < b)
    {
        Console.Write($"{a}, ");
        RecursMetodNumbs(a + 1, b);
    }
    else if (b < a)
    {
        Console.Write($"{b}, ");
        RecursMetodNumbs(a, b + 1);
    }
    else
    {
        Console.Write($"{a}. ");
    }
}

int SumRecursMetod(int a, int b)
{
    if (a < b)
    {
        return SumRecursMetod(a + 1, b) + a;
    }
    else if (b < a)
    {
        return SumRecursMetod(a, b + 1) + b;
    }
    else return a;
}

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if (a == b)
{
    Console.WriteLine($"Числа a и b равны: {a} ");
    Console.WriteLine("Введите число a");
    a = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите число b");
    b = int.Parse(Console.ReadLine());
}
RecursMetodNumbs(a, b);
Console.WriteLine($"Сумма чисел равна: {SumRecursMetod(a, b)}");
