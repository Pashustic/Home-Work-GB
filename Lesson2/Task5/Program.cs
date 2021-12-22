// Нужно ли человеку похудеть, набрать вес или всё в норме
//Павел Щербак
Console.WriteLine("Какой у вас вес в кг?");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Какой у вас рост в м?");
double height = Convert.ToDouble(Console.ReadLine());
double imt = weight / (height * height);                            //Расчитываем индекс массы тела
Console.WriteLine($"Ваш индекс массы тела (ИМТ): {imt:F2}");    //Выводим индекс массы тела, с двумя знаками после запятой

switch (imt)
{
    case < 18.5:
        Console.WriteLine($"Ваш вес: {weight}. Ваш рост: {height}.");
        Console.WriteLine($"У вас дефицит массы тела. Обратитесь к врачу!");
        Console.WriteLine($"Вам необходимо набрать {Math.Abs(18.5*(height*height)-weight):F0} кг");
        break;

    case < 24.9:
        Console.WriteLine($"У вас нормальная масса тела!");
        break;

    case < 29.9:
        Console.WriteLine($"У вас избыток веса! Займитесь спортом!");
        Console.WriteLine($"Вам необходимо сбросить {Math.Abs(29.9*(height*height)-weight):F0} кг");
        break;

    case < 34.9:
        Console.WriteLine($"У вас ожирение 1-й степени! Похуйдейте немедлено!");
        Console.WriteLine($"Вам необходимо сбросить {Math.Abs(29.9*(height*height)-weight):F0} кг");
        break;

    case < 39.9:
        Console.WriteLine($"У вас ожирение 2-й степени! Обратитесь к врачу-диетологу!");
        Console.WriteLine($"Вам необходимо сбросить {Math.Abs(29.9*(height*height)-weight):F0} кг");
        break;

    case > 39.9:
        Console.WriteLine($"У вас ожирение 3-й степени! Вы в зоне риска! Обратитесь к врачу");
        Console.WriteLine($"Вам необходимо сбросить {Math.Abs(29.9*(height*height)-weight):F0} кг");
        break;
}
