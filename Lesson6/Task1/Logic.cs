public delegate double Function(double a, double b);

class Fun
{
    public double firstFun(double a, double x)
    {
        return (a*(x*x));
    }

    public double TwoFun(double a, double x)
    {
        return (a*Math.Sin(x));
    }
}