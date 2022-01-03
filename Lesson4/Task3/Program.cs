//Task 3
//Павел Щербак
/* Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от начального значения с заданным шагом.
Создать свойство Sum, которое возвращает сумму элементов массива, 
метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений), 
метод Multi, умножающий каждый элемент массива на определённое число, 
свойство MaxCount, возвращающее количество максимальных элементов.  */

int [] arr2 = new int [5] {1,1,1,1,1};
int [] arr3 = new int [5] {1,3,1,3,1};
int value =3;
Arrays Methods = new Arrays(5,3,1);
System.Console.WriteLine($" Собранный в констуркторе массив: {Methods.Print(Methods.array)}");
System.Console.WriteLine($" Сумма элементов массива: {Methods.Sum}");
System.Console.WriteLine($" Инверсия массива: {Methods.Print(Methods.Inverse(Methods.array))}");
System.Console.WriteLine($" Собранный массив не изменился: {Methods.Print(Methods.array)}");
System.Console.WriteLine($" Умноженый массив на {value} равен: {Methods.Print(Methods.Multi(Methods.array, value))}");
System.Console.WriteLine($" Количество максимальных элементов: {Methods.MaxCount}");