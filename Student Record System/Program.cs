using System;

interface IStudent
{
    void Display();
}

class Student : IStudent
{
    private int[] marks = new int[3];
    public string Name { get; set; }

    // Indexer
    public int this[int index]
    {
        get { return marks[index]; }
        set { marks[index] = value; }
    }

    public void Display()
    {
        Console.WriteLine("Student Name: " + Name);
        Console.WriteLine("Marks:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Subject " + (i + 1) + ": " + marks[i]);
        }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Kafi";

        s[0] = 80;
        s[1] = 75;
        s[2] = 90;

        s.Display();
    }
}
