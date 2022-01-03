//Task5
// Павел Щербак
/* а) Реализовать библиотеку с классом для работы с двумерным массивом. 
Реализовать конструктор, заполняющий массив случайными числами. 
Создать методы, которые возвращают сумму всех элементов массива, 
сумму всех элементов массива больше заданного, 
свойство, возвращающее минимальный элемент массива, 
свойство, возвращающее максимальный элемент массива, 
метод, возвращающий номер максимального элемента массива (через параметры, используя модификатор ref или out). */

string NmaxElement = String.Empty;
DoubleArray doublearray = new DoubleArray(5,7,0,1000);
System.Console.WriteLine($"Построенный массив: \n{doublearray.Print(doublearray.array)}");
System.Console.WriteLine($"Сумма элементов массива: {doublearray.SumElements()}");
System.Console.WriteLine($"Сумма элементов массива с заданной позиции: {doublearray.SumElementsIndex(2,2)}");
System.Console.WriteLine($"Минимальный эллемент массива: {doublearray.MinElement}");
System.Console.WriteLine($"Максимальный эллемент массива: {doublearray.MaxElement}");
doublearray.NmaxElement(ref NmaxElement);
System.Console.WriteLine($"Адрес максимального эллемента: {NmaxElement}");