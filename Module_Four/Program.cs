using System;

namespace Module_Four
{
    struct Student
    {
        private string name;

        public Student(String name)
        {
            this.name = name;
        }

        public String Name
        { 
            get { return name; } 
            set { name = value; } 
        }
    }

    struct Teacher
    {
        private string name;

        public Teacher(String name)
        {
            this.name = name;
        }

        public String Name
        { 
            get { return name; } 
            set { name = value; } 
        }
    }

    struct Program
    {
        private string name;

        public Program(String name)
        {
            this.name = name;
        }

        public String Name
        { 
            get { return name; } 
            set { name = value; } 
        }
    }

    struct Course
    {
        private string name;

        public Course(String name)
        {
            this.name = name;
        }

        public String Name
        { 
            get { return name; } 
            set { name = value; } 
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Student[] students = new Student[5];

            students[0] = new Student("Minhaz");
            students[1] = new Student("Sumaia");
            students[2] = new Student("Jack");

            Console.WriteLine(students[0].Name);
            Console.WriteLine(students[1].Name);
            Console.WriteLine(students[2].Name);

        }
    }
}
