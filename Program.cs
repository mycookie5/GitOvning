// See https://aka.ms/new-console-template for more information

using System;

public class Person
{
    // Egenskaper som andra klasser kan ärva
    public int Age { get; set; }
    public string Name { get; set; }

    // konstrukter: Det första som initieras när man skapar en objeckt.
    public Person(int age, string namn) 
    {
        Name = namn;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"My name is {Name} and i am {Age} years old!");
    }
}

public class Student : Person
{
    public string grade { get; set; }

    public Student(string grade)
    {
        this.grade = grade;
    }
}