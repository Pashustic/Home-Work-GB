class Complex               // a+bi =c+di
{
    public double re; //вещественное
    public double im; //мнимое
    
    public Complex Minus(Complex x)
    {
        Complex y = new Complex();
        y.re = this.re - x.re;
        y.im = this.im - x.im;
        return y;
    }

    public Complex Multiplication(Complex x)
    {
        Complex y = new Complex();
        y.re = (this.re * x.re) - (this.im * x.im); //4+7i * 3+5i 12-35 = -23
        y.im = (this.im * x.re) + (this.re * x.im);
        return y;
    }

    public string ToString()
    {
        if (im < 0) return ($"{re}{im}i");
        else if (im==0) return ($"{re}");
        else if (re==0) return ($"{im}i");
        else return ($"{re}+{im}i");
    }
}