public class Racionaly
{
    int m;
    int n;
    public Racionaly Plus(Racionaly r)
    {
        Racionaly res = new Racionaly();
        res.m = this.m * r.n + r.m * this.n;
        res.n = this.n * r.n;
        return res;
    }
    public Racionaly Minus(Racionaly r)
    {
        Racionaly res = new Racionaly();
        res.m = this.m * r.n - r.m * this.n;
        res.n = this.n * r.n;
        return res;
    }
    public Racionaly Multiply(Racionaly r)
    {
        Racionaly res = new Racionaly();
        res.m = this.m * r.m;
        res.n = this.n * r.n;
        return res;
    }
    public Racionaly Division(Racionaly r)
    {
        Racionaly res = new Racionaly();
        res.m = this.m * r.n;
        res.n = this.n * r.m;
        return res;
    }

    public int M
    {
        get { return m; }
        set { m = value; }
    }

    public int N
    {
        get { return n; }
        set
        {
            if (value != 0)
             n = value;
            else throw new ArgumentException("Знаменатель не может быть равен 0");
        }
    }

    public double Decimal
    {
        get { return (double)m / n; }
    }

    int FindNOD(int x1,int x2)
    {
        int res = 1;
        for(int i = 2; i<= (x1<x2? x1:x2);i++)
        {
            if(x1% i == 0 && x2%i == 0)
            res = i;
        }
        return res;
    }

    public void Simplification()
    {
        int NOD = FindNOD(this.m,this.n);
        this.m = this.m / NOD;
        this.n = this.n / NOD;
    }
}