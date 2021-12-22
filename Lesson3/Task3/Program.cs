// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main()
    {
        Racionaly r1 = new Racionaly();
        r1.M = 10;
        r1.N = 15;
        Racionaly r2 = new Racionaly();
        r2.M = 1;
        r2.N = 3;
        System.Console.WriteLine(r1.Decimal);
        Racionaly r3 = new Racionaly();
        r3= r1.Plus(r2);
        System.Console.WriteLine(r3.Decimal);
         r3=r1.Minus(r2);
        System.Console.WriteLine(r3.Decimal);
         r3=r1.Multiply(r2);
        System.Console.WriteLine(r3.Decimal);
         r3=r1.Division(r2);
        System.Console.WriteLine(r3.Decimal);
        //r3.N = 0; Выбрасывает исключение
        r1.Simplification(); // Упрощение
        System.Console.WriteLine();
        System.Console.WriteLine(r1.M);
        System.Console.WriteLine(r1.N);
    }
}
