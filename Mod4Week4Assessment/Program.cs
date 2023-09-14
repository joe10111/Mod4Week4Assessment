using Mod4Week4Assessment;
using System;
using System.Collections.Generic;


public class Student : Person
{
    public int Grade { get; private set; }

    public Student(string name, int grade, DateTime birthday) : base(name, birthday)
    {
        Grade = grade;
    }

    public override string GetGreeting()
    {
        return $"Hello, I'm {Name}, a student in grade {Grade}!";
    }
}

public class Teacher : Person
{
    public string Subject { get; private set; }

    public Teacher(string name, string subject, DateTime birthday) : base(name, birthday)
    {
        Subject = subject;
    }

    public override string GetGreeting()
    {
        return $"Hello, I'm {Name}, a {Subject} teacher!";
    }
}

// Create a school class that uses dependency injection by taking in a list of people.
public class School
{
    private readonly List<Person> _people = new List<Person>();

    public School(List<Person> people)
    {
        _people = people;
    }

    public void ListBirthdays()
    {
        _people.ForEach(person => Console.WriteLine(person.GetBirthday()));
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        //// Your solution should make the following code run without errors!

        //// Step 1:
        //// Creating instances of Student and Teacher
        Student studentAlice = new Student("Alice", 10, new DateTime(2007, 1, 20));
        Student studentEthan = new Student("Ethan", 12, new DateTime(2005, 3, 10));
        Teacher teacherJohnson = new Teacher("Mrs. Johnson", "Math", new DateTime(1980, 12, 10));

        //// Creating a list of people
        List<Person> people = new List<Person> { studentAlice, studentEthan, teacherJohnson };

        //// Step 2:
        //// Using dependency injection to create a School instance
        School school = new School(people);

        //// List all birthdays
        school.ListBirthdays();
    }
}
