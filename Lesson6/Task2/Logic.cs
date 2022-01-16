public delegate int Min(int[] a);
public delegate string StrDelegat(int[] a);

public class Logic
{
    public int[] mass;
    public Logic(int a, int b, int count)
    {
        mass = new int[count];
        Random rnd = new Random();
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = rnd.Next(a, b);
        }
    }
    public int FunMin(int[] a)
    {
        int min = a[0];
        for (int j = 1; j < a.Length; j++)
        {
            if (a[j] < min)
            {
                min = a[j];
            }
        }
        return min;
    }

    public int FunMax(int[] a)
    {
        int max = a[0];
        for (int j = 1; j < a.Length; j++)
        {
            if (a[j] > max)
            {
                max = a[j];
            }
        }
        return max;
    }

    public string Print(int[] a)
    {
        string str = String.Empty;
        for (int k = 0; k < a.Length; k++)
        {
            str += a[k] + " ";
        }
        return str;
    }

}