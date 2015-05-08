using System;
using System.Threading;
using System.Collections;

namespace Module_Seven {

	class Student {
		public string FirstName {
			get;
			set;
		}
		public string LastName {
			get;
			set;
		}
		public Stack Grades = new Stack();
		public static int Count = 0;

		public Student(String FName, String LName) {
			FirstName = FName;
			LastName = LName;
			Interlocked.Increment(ref Count);
		}
	}

	class Teacher {
		public string FirstName {
			get;
			set;
		}
		public string LastName {
			get;
			set;
		}

		public Teacher(String FName, String LName) {
			FirstName = FName;
			LastName = LName;
		}
	}

	class Course {
		public string CourseName {
			get;
			set;
		}
		public string CourseCode {
			get;
			set;
		}
		public string Credit {
			get;
			set;
		}

		public ArrayList StudentList = new ArrayList();
		public ArrayList TeacherList = new ArrayList();

		public Course(String CName) {
			CourseName = CName;
		}

		public void AddStudent(Student _Student) {
			StudentList.Add(_Student);
		}

		public void AddTeacher(Teacher _Teacher) {
			TeacherList.Add(_Teacher);
		}

		public void ListStudents() {
			foreach(Object obj in StudentList) {
				Student student = (Student)obj;
				Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
			}
		}
	}

	class Degree {
		public string Name {
			get;
			set;
		}
		public Course _Course;

		public Degree(String DegreeName) {
			Name = DegreeName;
		}

		public void AddCourse(Course CourseObject) {
			_Course = CourseObject;
		}
	}

	class Program {
		public string Name {
			get;
			set;
		}
		public Degree _Degree;

		public Program(String ProgramName) {
			Name = ProgramName;
		}

		public void AddDegree(Degree DegreeObject) {
			_Degree = DegreeObject;
		}
	}


	class MainClass {
		public static void Main(string[] args) {
			/* Students */
			Student Minhaz = new Student("Minhaz", "Haque");
			Minhaz.Grades.Push(100);
			Minhaz.Grades.Push(90);
			Minhaz.Grades.Push(80);
			Minhaz.Grades.Push(70);
			Minhaz.Grades.Push(60);

			Student Sumaia = new Student("Sumaia", "Alavi");
			Sumaia.Grades.Push(100);
			Sumaia.Grades.Push(90);
			Sumaia.Grades.Push(80);
			Sumaia.Grades.Push(70);
			Sumaia.Grades.Push(60);

			Student Alveera = new Student("Alveera", "Haque");
			Alveera.Grades.Push(100);
			Alveera.Grades.Push(90);
			Alveera.Grades.Push(80);
			Alveera.Grades.Push(70);
			Alveera.Grades.Push(60);

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
			Program ITProgram = new Program("Information Technology");
			ITProgram.AddDegree(BachelorDegree);

			Console.WriteLine("The {0} contains the {1} Degree", ITProgram.Name, ITProgram._Degree.Name);
			Console.WriteLine("The {0} degree contains the course {1}", ITProgram._Degree.Name, ITProgram._Degree._Course.CourseName);
			Console.WriteLine("The {0} course contains {1} students", ITProgram._Degree._Course.CourseName, Student.Count);

			ProgrammingCSharp.ListStudents();
		}
	}
}