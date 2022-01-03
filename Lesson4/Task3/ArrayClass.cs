class Arrays
{
    public int[] array;
    private int sumElements;
    private int maxCount;
    public Arrays(int lenth, int firstellement, int step) //Конструктор массива
    {
        array = new int[lenth];
        for (int i = 0; i < lenth; i++)
        {
            array[i] = firstellement + step * i;
        }

    }

    public int Sum //Свойство возврата суммы элементов массива
    {
        get
        {
            for (int i = 0; i < array.Length; i++)
            {
                sumElements = sumElements + array[i];
            }
            return sumElements;
        }
    }

    public int[] Inverse(int[] array) //Метод инверсии эллементов массива
    {
        int[] inversarray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            inversarray[i] = array[i] * (-1);
        }
        return inversarray;
    }

    public int[] Multi(int[] array, int value) //Метод умножения массива на число
    {
        int[] arrmulti = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            arrmulti[i] = array[i] * value;
        }
        return arrmulti;
    }

    public string Print(int[] array) //Метод вывода массива
    {
        string str = String.Empty;
        for (int i = 0; i < array.Length; i++)
        {
            str = str + array[i] + " ";
        }
        return str;
    }

    public int MaxCount //Свойство поиска колличества максимальных эллементов
    {
        get
        {
            int max = array.Max();
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    maxCount++;
                }
            }
            return maxCount;
        }
    }
}
