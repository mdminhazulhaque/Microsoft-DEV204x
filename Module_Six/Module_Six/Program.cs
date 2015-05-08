using System;
using System.Threading;

namespace Module_Six
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Student: Person
    {
        public static int Count = 0;

        public Student(String FName, String LName)
        {
            FirstName = FName;
            LastName = LName;
            Interlocked.Increment(ref Count);
        }

        public void TakeTest()
        {
            Console.WriteLine("Taking Test");
        }
    }

    class Teacher : Person
    {
        public Teacher(String FName, String LName)
        {
            FirstName = FName;
            LastName = LName;
        }

        public void GradeTest()
        {
            Console.WriteLine("Grading Test");
        }
    }

    class Course
    {
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        public string Credit { get; set; }

        public Teacher[] Teachers = new Teacher[3];
        public Student[] Students = new Student[3];

        public int CountStudents = 0;
        public int CountTeachers = 0;

        public Course(String CName)
        {
            CourseName = CName;
        }

        public void AddStudent(Student _Student)
        {
            Students[CountStudents] = _Student;
            CountStudents++;
        }

        public void AddTeacher(Teacher _Teacher)
        {
            Teachers[CountTeachers] = _Teacher;
            CountTeachers++;
        }
    }

    class Degree
    {
        public string Name { get; set; }
        public Course _Course;

        public Degree(String DegreeName)
        {
            Name = DegreeName;
        }

        public void AddCourse(Course CourseObject)
        {
            _Course = CourseObject;
        }
    }


    class UProgram
    {
        public string Name { get; set; }
        public Degree _Degree;

        public UProgram(String ProgramName)
        {
            Name = ProgramName;
        }

        public void AddDegree(Degree DegreeObject)
        {
            _Degree = DegreeObject;
        }
    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            /* Students */
            Student Minhaz = new Student("Minhaz", "Haque");
            Student Sumaia = new Student("Sumaia", "Alavi");
            Student Alveera = new Student("Alveera", "Haque");

            /* Course */
            Course ProgrammingCSharp = new Course("Programming with C#");
            ProgrammingCSharp.AddStudent(Minhaz);
            ProgrammingCSharp.AddStudent(Sumaia);
            ProgrammingCSharp.AddStudent(Alveera);

            /* Teacher */
            Teacher Steve = new Teacher("Steve", "Whiting");
            ProgrammingCSharp.AddTeacher(Steve);

            /* Degree */
            Degree BachelorDegree = new Degree("Bachelor");
            BachelorDegree.AddCourse(ProgrammingCSharp);

            /* Program */
            UProgram ITProgram = new UProgram("Information Technology");
            ITProgram.AddDegree(BachelorDegree);

            Console.WriteLine("The {0} contains the {1} Degree", ITProgram.Name, ITProgram._Degree.Name);
            Console.WriteLine("The {0} degree contains the course {1}", ITProgram._Degree.Name, ITProgram._Degree._Course.CourseName);
            Console.WriteLine("The {0} course contains {1} students", ITProgram._Degree._Course.CourseName, Student.Count);
        }
    }
}
