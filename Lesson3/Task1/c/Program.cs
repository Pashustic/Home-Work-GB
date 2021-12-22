
class Program
{
    static void Main()
    {
        int re1, im1, re2, im2;
        string s;
        bool flag;
        Console.WriteLine("Программа выполняет математические операции с комплексными числами!");
        do
        {
            Console.Write("Введите число которое является вещественной частью первого комплесного числа: ");
            s = Console.ReadLine();
            flag = int.TryParse(s, out re1);
        }
        while (!flag);
        flag = false;
        do
        {
            Console.Write("Введите число которое является мнимой частью первого комплесного числа: ");
            s = Console.ReadLine();
            flag = int.TryParse(s, out im1);
        }
        while (!flag);
        flag = false;
        do
        {
            Console.Write("Введите число которое является вещественной частью второго комплесного числа: ");
            s = Console.ReadLine();
            flag = int.TryParse(s, out re2);
        }
        while (!flag);
        flag = false;
        do
        {
            Console.Write("Введите число которое является мнимой частью второго комплесного числа: ");
            s = Console.ReadLine();
            flag = int.TryParse(s, out im2);
        }
        while (!flag);
        flag = false;

        if (im1 < 0) Console.WriteLine($"Первое комплексное число: {re1}{im1}i");
        else Console.WriteLine($"Первое комплексное число: {re1}+{im1}i");

        if (im2 < 0) Console.WriteLine($"Первое комплексное число: {re2}{im2}i");
        else Console.WriteLine($"Первое комплексное число: {re2}+{im2}i");

        Complex complex1 = new Complex();
        complex1.re = re1;
        complex1.im = im1;

        Complex complex2 = new Complex();
        complex2.re = re2;
        complex2.im = im2;

        do
        {
            Console.Write("Введите операцию которую хотите произвести (+;-;/;*) и нажмите Enter: ");
            s = Console.ReadLine();
            switch (s)
            {
                case "+":
                    Complex result = complex1.Plus(complex2);
                    Console.WriteLine(result.ToString());
                    flag = true;
                    break;
                case "-":
                    Complex result2 = complex1.Minus(complex2);
                    Console.WriteLine(result2.ToString());
                    flag = true;
                    break;
                case "*":
                    Complex result3 = complex1.Multiplication(complex2);
                    Console.WriteLine(result3.ToString());
                    flag = true;
                    break;
                case "/":
                    Complex result4 = complex1.Dividing(complex2);
                    Console.WriteLine(result4.ToString());
                    flag = true;
                    break;
            }
        }
        while (!flag);
    }

}
