int n = 5;
char symbol = 'е'; 
string message = "Вывести только те слова сообщения, которыеaf содержат содержатv не более n букв.";
Message Methods = new Message();
Methods.WordN(message,n);
System.Console.WriteLine(Methods.DelWord(message,symbol));
System.Console.WriteLine(Methods.MaxLenthWord(message));
System.Console.WriteLine(Methods.MaxLenthWordString(message));