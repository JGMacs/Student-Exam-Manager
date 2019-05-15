using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    static class FileManager
    {
        private static ObservableCollection<Student> studentList = new ObservableCollection<Student>();

        private static BindingList<string> names = new BindingList<string>();

        //Function to create new Student profile
        public static void CreateStudent(string name, IList<int> grades)
        {
            studentList.Add(new Student(name) );

            for (int i=0; i <= grades.Count; i++)
            {
                try {
                    studentList[studentList.Count - 1].AddGrade(grades[i]);
                } catch { }
            }

            resetNames();
        }

        //Function to add new score to Student profile
        public static void AddScore(int index, int grade)
        {
            studentList[index].AddGrade(grade);
        }

        //Function to update score in Student profile
        public static void UpdateScore(int index, int gradeIndex, int grade)
        {
            studentList[index].UpdateGrade(gradeIndex, grade);
        }

        //Function to remove score in Student profile
        public static void RemoveScore(int index, int gradeIndex)
        {
            studentList[index].RemoveGrade(gradeIndex);
        }

        //Function to delete Student profile
        public static void RemoveStudent(int index)
        {
            studentList.RemoveAt(index);

            resetNames();
        }

        //Function to delete all of a Student's grades
        public static void ClearScores(int index)
        {
            studentList[index].ClearScores();
        }

        //Getter function for studentList
        public static IList<Student> StudentList => studentList;

        //Getter function for student names
        public static IList<string> NameList => names;

        //Function to reset list of student names on update of info
        private static void resetNames()
        {
            names.Clear();

            for (int i = 0; i < studentList.Count; i++)
            {
                names.Add(studentList[i].GetName());
            }
        }

        //Function to create test students
        public static void TestStudents()
        {
            string name1 = "Testy McGee";
            string name2 = "Jimmy Barnes";
            string name3 = "[redacted]";

            IList<int> grades1 = new List<int> { 99, 83, 89 };
            IList<int> grades2 = new List<int> { 44, 44, 41 };
            IList<int> grades3 = new List<int> { 98, 93, 66 };

            CreateStudent(name1, grades1);
            CreateStudent(name2, grades2);
            CreateStudent(name3, grades3);
        }
    }

    //Student Class: Used to create/update student profiles
    public class Student
    {
        //Student's name
        private readonly string _studentName;

        //List of Student's current grades
        private BindingList<int> gradeList = new BindingList<int>();

        //Default Constructor
        public Student() {}

        //Constructor to create student profile
        public Student(string name)
        {
            _studentName = name;
        }

        //Function to add grade to student's records
        public void AddGrade(int grade)
        {
            try {
                gradeList.Add(grade);
            } catch {
                MessageBox.Show("Please enter a valid grade number in integer format.");
            }
        }

        //Function to update grade in student's records
        public void UpdateGrade(int gradeIndex, int grade)
        {
            try {
                gradeList.Insert(gradeIndex, grade);
                gradeList.RemoveAt(gradeIndex + 1);
            } catch {
                MessageBox.Show("Please enter a valid grade number in integer format.");
            }
        }

        //Function to remove grade in student's records
        public void RemoveGrade(int index)
        {
            try {
                this.gradeList.RemoveAt(index);
            } catch {
                MessageBox.Show("Error: No grade at that index.");
            }
        }

        //Clear Scores
        public void ClearScores()
        {
            this.gradeList.Clear();
        }

        //Get/Set function for student name
        public string GetName()
        {
            return _studentName;
        }

        //Get/Set function tfor student grades
        public IList<int> GradesList => gradeList;
    }
}
