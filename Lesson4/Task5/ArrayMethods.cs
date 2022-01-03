class DoubleArray
{
    public int[,] array;
    int colums;
    int rows;
    int minElement;
    int maxElement;
    public DoubleArray(int col, int row, int minValue, int maxValue)
    {
        
        rows = row;
        colums = col;
        array = new int[rows, colums];
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                array[i, j] = rnd.Next(minValue, maxValue);
            }
        }
    }

    public int SumElements()
    {
        int sum = 0;
        for (int i = 0; i < this.rows; i++)
        {
            for (int j = 0; j < this.colums; j++)
            {
                sum = sum + array[i, j];
            }
        }
        return sum;
    }

    public int SumElementsIndex(int indexcol, int indexrow)
    {
        int sum = 0;
        for (int i = indexcol; i < this.rows; i++)
        {
            for (int j = indexrow; j < this.colums; j++)
            {
                sum = sum + array[i, j];
            }
        }
        return sum;
    }

    public int MinElement
    {
        get
        {
            minElement = array[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (minElement > array[i, j])
                    {
                        minElement = array[i, j];
                    }
                }
            }
            return minElement;
        }
    }
    public int MaxElement
    {
        get
        {
            maxElement = array[0, 0];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (maxElement < array[i, j])
                    {
                        maxElement = array[i, j];
                    }
                }
            }
            return maxElement;
        }
    }

    public void NmaxElement(ref string NmaxElement)
    {
        maxElement = array[0, 0];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                if (maxElement < array[i, j])
                {
                    maxElement = array[i, j];
                    NmaxElement = $"[{i+1},{j+1}]";
                }
            }
        }
    }

    public string Print(int[,] array)
    {
        string str = String.Empty;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                str = str + array[i,j] + " ";
            }
            str = str +"\n";
        }
        return str;
    }
}