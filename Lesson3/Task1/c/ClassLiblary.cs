class Complex               // a+bi =c+di
{
    public double re; //вещественное
    public double im; //мнимое

    public Complex Plus(Complex x)
    {
        Complex y = new Complex();
        y.re = this.re + x.re;
        y.im = this.im + x.im;
        return y;
    }
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
        y.re = (this.re * x.re) - (this.im * x.im); 
        y.im = (this.im * x.re) + (this.re * x.im);
        return y;
    }
    public Complex Dividing (Complex x)
    {
        Complex y = new Complex();
        y.re = ((this.re * x.re) + (this.im * x.im))/((x.re*x.re)-(x.im*x.im*(-1))); 
        y.im = ((this.im * x.re) - (this.re * x.im))/((x.re*x.re)-(x.im*x.im*(-1)));
        return y;
    }

    public string ToString()
    {
        if (im < 0) return ($"{re:F1}{im:F1}i");
        else if (im == 0) return ($"{re:F1}");
        else if (re == 0) return ($"{im:F1}i");
        else return ($"{re:F1}+{im:F1}i");
    }
}
