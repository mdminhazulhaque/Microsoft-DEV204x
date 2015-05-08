using System;

namespace Module_Three
{
    class MainClass
    {
        static void PrintStudentDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetStudentInfo()
        {
            Console.WriteLine("Enter the student's first name");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            String lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday");
            String birthday = Console.ReadLine();

            PrintStudentDetails(firstName, lastName, birthday);
        }

        /*****************************************************************************/

        static void PrintTeacherDetails(string first, string last, string birthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", first, last, birthday);
        }

        static void GetTeacherInfo()
        {
            Console.WriteLine("Enter the teacher's first name");
            String firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            String lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday");
            String birthday = Console.ReadLine();

            PrintTeacherDetails(firstName, lastName, birthday);
        }

        /*****************************************************************************/

        static void PrintProgramDetails(string code, string title, string host)
        {
            Console.WriteLine("Code: {0} Title: {1} hosted by {2}", code, title, host);
        }

        static void GetProgramInfo()
        {
            Console.WriteLine("Enter the program title");
            String code = Console.ReadLine();
            Console.WriteLine("Enter the program code");
            String title = Console.ReadLine();
            Console.WriteLine("Enter the host university");
            String host = Console.ReadLine();

            PrintProgramDetails(code, title, host);
        }

        /*****************************************************************************/

        static void PrintCourseDetails(string name, string description, string credit)
        {
            Console.WriteLine("Course: {0} Description: {1} Credit {2}", name, description, credit);
        }

        static void GetCourseInfo()
        {
            Console.WriteLine("Enter course name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter course description");
            String description = Console.ReadLine();
            Console.WriteLine("Enter course credit");
            String credit = Console.ReadLine();

            PrintCourseDetails(name, description, credit);
        }

        /*****************************************************************************/

        static void PrintDegreeDetails(string name, string type, string datecompleted)
        {
            Console.WriteLine("Degree {0} Type {1} Completed on {2}", name, type, datecompleted);
        }

        static void GetDegreeInfo()
        {
            Console.WriteLine("Enter degree name");
            String name = Console.ReadLine();
            Console.WriteLine("Enter degree type");
            String type = Console.ReadLine();
            Console.WriteLine("Enter completion date");
            String datecompleted = Console.ReadLine();

            PrintDegreeDetails(name, type, datecompleted);
        }

        /*****************************************************************************/

        public static void Main(string[] args)
        {
            GetStudentInfo();
            GetTeacherInfo();
            GetProgramInfo();
            GetCourseInfo();
            GetDegreeInfo();
        }
    }
}
