class ArrayMethods
{
    public void RandomFillArray(int[] array, int value) // метод получает массив и диапазон
    {
        Random randomFill = new Random(); //создаем класс Random
        for (int i = 0; i < array.Length; i++) //Цикл заполнения массива
        {
            array[i] = randomFill.Next(-value, value); //В i ячейку массива записываем случайное число в диапазоне от -value до value
        }

    }

    public string PrintArray(int[] array) //метод формирования строки для вывода массива
    {
        string result = String.Empty; //создаем пустую строку
        for (int i = 0; i < array.Length; i++) //Цикл прогона массива
        {
            result += array[i] + " "; //Записываем в строку i эллемент массива
        }
        return result; //Возвращаем собраную строку
    }

    public int DoubleEllements(int[] array) //Метод поиска пар делящихся на 3
    {
        int sum = 0; //Счётчик пар
        for (int i = 1; i < array.Length; i++) //Цикл прохода массива
        {
            if (array[i] % 3 == 0 && array[i - 1] % 3 != 0) sum++; //Если i элемент делиться на 3, а предыдущий нет, то увеличить счётчик на 1
            else if (array[i - 1] % 3 == 0 && array[i] % 3 != 0) sum++;//Если i элемент не делиться на 3, а предыдущий делиться, то увеличить счётчик на 1
        }
        return sum; // Вернуть колличество пар
    }

    public int[] FillFromFiles(string addres) // Метод заполения массива из файла
    {
        string data = File.ReadAllText(addres); //Записываем данные из файла в переменную
        string[] ellements = data.Split(new char[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries); //Выбираем элементы из переменной по разделителям
        int[] result = new int[ellements.Length]; //Создаем массив для хранения результата
        for (int i = 0; i < result.Length; i++) //Прогоняем массив
        {
            result[i] = int.Parse(ellements[i]); //Записываем в i элемент массива, преведенный к целочисленному типу i элемент строчного массива            
        }
        return result; //Возвращаем заполненый массив    
    }

    public void CheckFile(string addres) //Метод проверки наличия файла
    {
        try
        {
            string data = File.ReadAllText(addres);// Записываем данные из файла
        }
        catch (System.IO.FileNotFoundException) //В случае отсутствия файла выводим сообщение об ошибке
        {
            Console.WriteLine("Данный файл отсутствует!");
        }
    }
}