// See https://aka.ms/new-console-template for more information

public class Person
{
    // Egenskaper som andra klasser kan ärva
    public int Age { get; set; }
    public string Name { get; set; }

    // konstrukter: Det första som initieras när man skapar en objeckt.

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"My name is {Name} and i am {Age} years old!");
    }
}

public class Student : Person
{
    public int ID { get; set; }
    public string Grade { get; set; }

    // base visar att man ärver variablerna från bas klassen Person.
    public Student (string name, int age, int id, string grade) : base (name, age)
    {
        ID = id;
        Grade = grade;
        Name = name;
        Age = age;
    }

    public void DisplayStudentInfo()
    {
        DisplayInfo();
        Console.WriteLine($"ID: {ID} Grade: {Grade}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student studentK = new Student("Fanual", 22, 2174128, "MVG");
        studentK.DisplayStudentInfo();
    }
}