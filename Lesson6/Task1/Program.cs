class Program
{
    static void Main()
    {
        System.Console.WriteLine("Введите a и x функции!");
        System.Console.Write("a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Fun fun =new Fun();
        Function F1 = fun.firstFun;
        Function F2 = fun.TwoFun;

        System.Console.WriteLine(F1(a,x));
        System.Console.WriteLine(F2(a,x));
    }
}