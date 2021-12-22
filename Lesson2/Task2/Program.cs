// See https://aka.ms/new-console-template for more information
int Numb(int x)
{
    int i = 0;
    while (x > 0)
    {
        x = x / 10;
        i++;
    }
    return i;
}

Console.WriteLine("Введите число:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Количество цифр в числе равно {Numb(x)}");
