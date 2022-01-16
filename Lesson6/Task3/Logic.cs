


class Student
{
    public string lastName;
    public string firstName;
    public int course;
    public int age;
    // Создаем конструктор
    public Student(string firstName, string lastName, int course, int age)
    {
        this.lastName = lastName;
        this.firstName = firstName;
        this.course = course;
        this.age = age;
    }
}
class Logic
{
    public int AgeStudentCompare(Student st1, Student st2)          
    {
        return String.Compare(st1.age.ToString(), st2.age.ToString());
    }
    public void StudentsSort( List<Student> studentlist, StreamReader filestudents, int student5k, int student6k)
    {
        while (!filestudents.EndOfStream)
        {
            string[] str = filestudents.ReadLine().Split(';');
            studentlist.Add(new Student(str[0], str[1], int.Parse(str[2]), int.Parse(str[3])));
            if (int.Parse(str[2]) == 5)
            {
                student5k++;
            }
            else if (int.Parse(str[2]) == 6)
            {
                student6k++;
            }
            filestudents.Close();
            studentlist.Sort(new Comparison<Student>(AgeStudentCompare));
        }
    }

}
