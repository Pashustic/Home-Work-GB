// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        Complex complex1; //1+1i        //1-2 + 1i-2i = -1-1i
        complex1.re = 1;
        complex1.im = 1;

        Complex complex2; //2+2i
        complex2.re = 2;
        complex2.im = 2;

        Complex result = complex1.Minus(complex2);
        Console.WriteLine(result.ToString());
    }
}

