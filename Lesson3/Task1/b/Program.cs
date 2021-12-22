class Program
{
    static void Main(string[] args)
    {
        Complex complex1 = new Complex(); //4+7i 
        complex1.re = 4;
        complex1.im = 7;

        Complex complex2 = new Complex(); //3+5i
        complex2.re = 3;
        complex2.im = 5;

        Complex result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString());


        Complex result2 = complex1.Multiplication(complex2);
        Console.WriteLine(result2.ToString());
    }
}