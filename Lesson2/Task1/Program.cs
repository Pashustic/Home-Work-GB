// See https://aka.ms/new-console-template for more information
double MinNumber(double a, double b, double c)
{
    if (a > b)
    {
        a = b;
    }
    else if (a > c)
    {
        a = c;
    }
    return a;
}

Console.WriteLine("Введите число a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число c");
double c = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Среди введённых чисел: {a}, {b}, {c} минимальное число {MinNumber(a, b, c)}");
