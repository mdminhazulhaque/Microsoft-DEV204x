using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mod_9_Homework
{
    class Student
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String City { get; set; }        
    }

    public partial class MainWindow : Window
    {
        private int index = -1;
        private List<Student> StudentList;

        public MainWindow()
        {
            InitializeComponent();
            StudentList = new List<Student>();
        }

        private void btnCreateStudent_Click(object sender, RoutedEventArgs e)
        {
            Student NewStudent = new Student();
            NewStudent.FirstName = txtFirstName.Text;
            NewStudent.LastName = txtLastName.Text;
            NewStudent.City = txtCity.Text;

            StudentList.Add(NewStudent);

            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCity.Text = "";
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            // if top of the list reached, reset index to zero
            if (index == StudentList.Count - 1)
            {
                index = 0;
            }
            else
            {
                index++;
            }
            showStudentInfo();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            // if bottom of the list reached, reset index as maximum index
            if(index == 0)
            {
                index = StudentList.Count - 1;
            }
            else
            {
                index--;
            }
            showStudentInfo();
        }

        private void showStudentInfo()
        {
            Student CurrStudent = StudentList.ElementAt(index);
            txtFirstName.Text = CurrStudent.FirstName;
            txtLastName.Text = CurrStudent.LastName;
            txtCity.Text = CurrStudent.City;
        }

    }
}
