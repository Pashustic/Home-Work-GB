using System.Text.RegularExpressions;
class Logic
{

    Regex myReg = new Regex(@"^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
    public void FailLogin(string login)
    {
        if (login.Length > 1 && login.Length < 9)
        {
            char a = login[0];
            if (char.IsDigit(a))
            {
                Console.WriteLine("Некоретный логин! Введите логин!");
                login = Console.ReadLine();
                FailLogin(login);
            }
            else
            {
                for (int i = 1; i < login.Length; i++)
                {
                    a = login[i];
                    if (char.IsLetterOrDigit(a) == false)
                    {
                        Console.WriteLine("Некоретный логин! Введите логин!");
                        login = Console.ReadLine();
                        FailLogin(login);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Некоретный логин! Введите логин!");
            login = Console.ReadLine();
            FailLogin(login);
        }
    }

    public void RegularMethod(string login)
    {
        if (myReg.Match(login).Success)
        {
            Console.WriteLine("Логин введен верно!");
        }
        else
        {
            Console.WriteLine("Некоретный логин! Введите логин!");
            login = Console.ReadLine();
            RegularMethod(login);
        }
    }
}