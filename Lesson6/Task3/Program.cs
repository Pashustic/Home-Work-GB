
//Переделать программу Пример использования коллекций для решения следующих задач:
// а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
// б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся(*частотный массив);
// в) отсортировать список по возрасту студента;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main()
    {
        int student5k = 0;
        int student6k = 0;
        List<Student> studentlist = new List<Student>();
        StreamReader filestudents = new StreamReader("students.txt");
        Logic logic = new Logic();
        System.Console.WriteLine(logic.AgeStudentCompare);
        logic.StudentsSort( studentlist, filestudents, student5k, student6k);
    }


}
