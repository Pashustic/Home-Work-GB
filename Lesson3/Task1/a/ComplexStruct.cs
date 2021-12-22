struct Complex
{
    public double im; 
    public double re; 
    public Complex Minus(Complex x)
    {
        Complex y;                 
        y.im = im - x.im;
        y.re = re - x.re;
        return y;
    }
    public string ToString()
    {
        if (im<0) return ($"{re}{im}i");
        else return ($"{re}+{im}i");
    }
}