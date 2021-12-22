// See https://aka.ms/new-console-template for more information
Console.WriteLine("Данная программа посчитает сумму всех введенных положительных нечетных чисел");
Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int sum = 0;
while (a != 0)
{
    if (a % 2 != 0 && a > 0)
    {
        sum = sum + a;
        Console.WriteLine("Введите число:");
        a = Convert.ToInt32(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Введите число:");
        a = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine($"Сумма введённых нечетных положительных чисел равна {sum}");
