//Task 1
//Павел Щербак
/* Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов,
содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:

а) без использования регулярных выражений;
б) **с использованием регулярных выражений. */

Console.WriteLine("Введите логин!");
string login = Console.ReadLine();
Logic ValidLogin = new Logic();
ValidLogin.FailLogin(login); //без регулярных выражений
ValidLogin.RegularMethod(login); //с использованием регулярных выражений.