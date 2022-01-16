class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите начальное и конечное значение!");
        System.Console.Write("Начальное значение: ");
        int a = int.Parse(Console.ReadLine());
        System.Console.Write("Конечное значение: ");
        int b = int.Parse(Console.ReadLine());
        System.Console.Write("Сколько эллементов в промежутке будем сравнивать? ");
        int count = int.Parse(Console.ReadLine());
        bool flag = true;
        Logic logic = new Logic(a, b, count);
        Min minElem = logic.FunMin;
        Min maxElem = logic.FunMax;
        StrDelegat str = logic.Print;
        do
        {
            System.Console.WriteLine(@"Введите номер действия для эллементов:
        1. Найти минимум
        2. Найти максимум
        9. Вывести эллементы
        0. Закончить работу");

            switch (Int32.Parse(Console.ReadLine()))
            {
                case 1:
                    System.Console.WriteLine($"Минимальный элемент из случайных в промежутке от {a} до {b}: {minElem(logic.mass)}");
                    break;

                case 2:
                    System.Console.WriteLine($"Минимальный элемент из случайных в промежутке от {a} до {b}: {maxElem(logic.mass)}");
                    break;

                case 9:
                    System.Console.WriteLine($"Случайные элементы в промежутке от {a} до {b}: {str(logic.mass)}");
                    break;

                case 0:
                    flag = false;
                    break;

                default:
                    System.Console.WriteLine("Действия с таким номером нет!");
                    break;
            }
        }
        while (flag!=false);

    }
}
