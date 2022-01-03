class Account
{
    string[] userData;
    public Account(string addres)
    {
        string file = File.ReadAllText(addres);
        string[] str = file.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        userData = new string[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            userData[i] = str[i];
        }
    }

    /* Очень сомневаюсь, что правильно выполнил задание, так как по факту из Main 
    кроме адреса ничего не передается и получается я в логику замешал интерфейс, 
    если это так подскажите под каким углом логики нужно было смотреть на эту задачу?! 
    Что передавать и что возвращать!
    Скорее всего, я подозреваю что для получения данных свой метод, потом метод проверки правильности авторизации
    и если пользователь не правильно ввёл данные мы снова вызываем метод на получения данных. И методы должны напрямую влиять на базовые данные,
    если в методе изменилось колличество попыток входа, то и в Main,а потом Print получает и смотрит, что выводить!
    Если я вообще не правильно вижу, подскажите как будет правильнее!*/
    public void Authorization() 
    {
        int value = 3;
        System.Console.Write("Введите логин: ");
        string log = Console.ReadLine();
        System.Console.Write("Введите пароль: ");
        string pass = Console.ReadLine();
        while (value > 0)
        {
            for (int i = 0; i < this.userData.Length; i = i + 2)
            {
                if (this.userData[i] == log && this.userData[i + 1] == pass)
                {
                    System.Console.Write($"Добро пожаловать!");
                    value=-1;
                }
            }
            if (value>0)
            {
                System.Console.WriteLine($"Вы ввели неверные данные! У вас осталось попыток входа: {value}");
                value--;
                System.Console.Write("Введите логин: ");
                log = Console.ReadLine();
                System.Console.Write("Введите пароль: ");
                pass = Console.ReadLine();
            }
        }
        if (value==0)
        {
            System.Console.WriteLine("Ваш аккаунт заблокирован!");
        }
    }
}