using System;
using System.IO;
class Program
{
    static void Main()
    {
        int[] array = new int[20];
        Logic.MethodA(array);
        int[]a = Logic.TextRead("Text.txt");
        foreach(int x in a)
            Console.Write($"{x} ");
    }
}
