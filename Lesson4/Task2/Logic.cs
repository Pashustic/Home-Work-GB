static class Logic
{
    public static void MethodA(int[] array)
    {
        int min = -10000;
        int max = 10000;
        int count = 0;
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(min, max);
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] % 3 == 0 && array[i - 1] % 3 != 0) count++;
            else if (array[i - 1] % 3 == 0 && array[i] % 3 != 0) count++;
        }
        System.Console.WriteLine(count);
    }

    public static int[] TextRead(string fileName)
    {
        string arr = File.ReadAllText(fileName);
        string[] ss = arr.Split(",",StringSplitOptions.RemoveEmptyEntries);
        int N = ss.Length;
        int[] res = new int[N];
        //  Считываем массив
        for (int i = 0; i <  N; i++)
        {
            res[i] = int.Parse(ss[i]);
        }
        return res;
    }

}