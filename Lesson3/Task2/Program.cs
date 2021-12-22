// See https://aka.ms/new-console-template for more information
Console.Write("Введите число: ");
int num;
int sum = 0;
int.TryParse(Console.ReadLine(), out num);
while (num != 0)
{
    if (num % 2 != 0 && num > 0)
    {
        sum += num;
        Console.WriteLine($"{num} - нечетное положительное");
    }
    Console.Write("Введите число: ");
    int.TryParse(Console.ReadLine(), out num);
}
Console.WriteLine($"Сумма чисел равна: {sum}");
