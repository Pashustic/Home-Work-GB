// Реализовать метод проверки логина и пароля.
// Павел Щербак
void Authorization(string login, string password)
{
    int i = 3;
    do
    {
        if (login == "root" && password == "GeekBrains")
        {
            Console.WriteLine("Авторизация успешна!");
            i = 0;
        }
        else if (i > 1)
        {
            i--;
            Console.WriteLine($"Введенные данные не верны! Осталось попыток {i}");
            Console.Write("Введите ваш логин: ");
            login = Console.ReadLine();
            Console.Write("Введите ваш пароль: ");
            password = Console.ReadLine();
        }
        else
        {
            i--;
            Console.WriteLine($"Вход запрещен! Восстановите данные!");
        }
    }
    while (i != 0);
}

string login;
string password;
Console.Write("Введите ваш логин: ");
login = Console.ReadLine();
Console.Write("Введите ваш пароль: ");
password = Console.ReadLine();
Authorization(login, password);