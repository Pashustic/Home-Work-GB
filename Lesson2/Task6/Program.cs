// Написать программу подсчета количества «хороших» чисел в диапазоне от 1 до 1 000 000 000.
//Павел Щербак
//1 Начальная версия
// Время работы программы:00:00:50.6859215
/*
int goodNumber = 0;
DateTime start = DateTime.Now;
for (int i = 1; i != 1000000000; i++)
{
    int x = 0;
    int a = i;
    string s = Convert.ToString(i);
    for (int j = 0; j != s.Length; j++)
    {
        x = x + (a % 10);
        a = a / 10;
    }
     if (i % x == 0)
        {
            goodNumber++;
        }
}
Console.WriteLine($"В диапазоне от 1 до 1 000 000 000 \"хороших\" чисел - {goodNumber}");
Console.WriteLine($"Время работы программы:{(DateTime.Now - start)}");
*/

// 2 Версия, оптимизировал, сэкономил 5 секунд
// Время работы программы:00:00:45.3932259
int goodNumber = 0;
DateTime start = DateTime.Now;
for (int i = 1; i <= 1000000000; i++)
{
    int sum = 0;
    //string s = Convert.ToString(i);
    for (int numb = i; numb != 0; numb = numb / 10)
    {
        sum = sum + (numb % 10);
    }
    if (i % sum == 0)
    {
        goodNumber++;
    }
}
Console.WriteLine($"В диапазоне от 1 до 1 000 000 000 \"хороших\" чисел - {goodNumber}");
Console.WriteLine($"Время работы программы:{(DateTime.Now - start)}");