using System;
using System.Threading;
using System.Collections.Generic;

namespace Module_Eight {

	class Student {
		public string FirstName {
			get;
			set;
		}
		public string LastName {
			get;
			set;
		}
		public Stack < String > Grades = new Stack < String > ();
		public static int Count = 0;

		public Student(String FName, String LName) {
			FirstName = FName;
			LastName = LName;
			Interlocked.Increment(ref Count);
		}

        public void AddGrade(String Grade) {
            Grades.Push(Grade);
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

		public List < Student > StudentList = new List < Student > ();
		public List < Teacher > TeacherList = new List < Teacher > ();

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
			foreach(Student student in StudentList) {
				Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
			}
		}
	}

	class MainClass {
		public static void Main(string[] args) {
			/* Students */
			Student Minhaz = new Student("Minhaz", "Haque");
			Minhaz.AddGrade("A");
			Minhaz.AddGrade("B");
			Minhaz.AddGrade("C");
			Minhaz.AddGrade("D");
			Minhaz.AddGrade("F");

			Student Sumaia = new Student("Sumaia", "Alavi");
			Sumaia.AddGrade("A");
			Sumaia.AddGrade("B");
			Sumaia.AddGrade("C");
			Sumaia.AddGrade("D");
			Sumaia.AddGrade("F");

			Student Alveera = new Student("Alveera", "Haque");
			Alveera.AddGrade("A");
			Alveera.AddGrade("B");
			Alveera.AddGrade("C");
			Alveera.AddGrade("D");
			Alveera.AddGrade("F");

			/* Course */
			Course ProgrammingCSharp = new Course("Programming with C#");
			ProgrammingCSharp.AddStudent(Minhaz);
			ProgrammingCSharp.AddStudent(Sumaia);
			ProgrammingCSharp.AddStudent(Alveera);

			/* Teacher */
			Teacher Steve = new Teacher("Steve", "Whiting");
			ProgrammingCSharp.AddTeacher(Steve);

			ProgrammingCSharp.ListStudents();
		}
	}
}