using System;
using System.Collections.Generic;
using System.Configuration;
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

namespace LINQ_TO_SQL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        LinqToSQLDataContext context;
        public MainWindow()
        {
            InitializeComponent();

            string connectionString = ConfigurationManager.ConnectionStrings["LINQ_TO_SQL.Properties.Settings.Database_TutorialConnectionString"].ConnectionString;

            context = new LinqToSQLDataContext(connectionString);

            AddUniversities();
            InsertStudents();
            InsertLectures();
            InsertStudentsLectures();
            GetUniversityOfToni();
            GetLecturesOfToni();
            GetAllStudentsFromYale();
            AllUniversitiesWithTrans();
            GetLecturesFromSpecificUni();
            UpdateToni();
            DeleteAnn();
        }

        public void AddUniversities()
        {
            context.ExecuteCommand("delete from university");

            University yale = new University();
            yale.Name = "Yale";
            context.Universities.InsertOnSubmit(yale);

            University beijing = new University();
            beijing.Name = "Beijing Tech";
            context.Universities.InsertOnSubmit(beijing);

            context.SubmitChanges();

            DataGridId.ItemsSource = context.Universities;
        }

        public void InsertStudents()
        {
            University yale = context.Universities.First(un => un.Name.Equals("Yale"));
            University beijing = context.Universities.First(un => un.Name.Equals("Beijing Tech"));

            List<Student> students = new List<Student>();
            students.Add(new Student { Name = "Carla", Gender = "female", UniversityId = yale.Id});
            students.Add(new Student { Name = "Toni", Gender = "male", University = yale});
            students.Add(new Student { Name = "Layla", Gender = "female", University = beijing });
            students.Add(new Student { Name = "Ann", Gender = "trans-gender", University = beijing });

            context.Students.InsertAllOnSubmit(students);

            context.SubmitChanges();

            DataGridId.ItemsSource = context.Students;
        }

        public void InsertLectures()
        {
            context.Lectures.InsertOnSubmit(new Lecture { Name = "Math"});
            context.Lectures.InsertOnSubmit(new Lecture { Name = "History" });
            context.Lectures.InsertOnSubmit(new Lecture { Name = "Geography" });

            context.SubmitChanges();

            DataGridId.ItemsSource = context.Lectures;
        }

        public void InsertStudentsLectures()
        { 
            Student Carla = context.Students.First(st => st.Name.Equals("Carla"));
            Student Toni = context.Students.First(st => st.Name.Equals("Toni"));
            Student Layla = context.Students.First(st => st.Name.Equals("Layla"));
            Student Ann = context.Students.First(st => st.Name.Equals("Ann"));

            Lecture Math = context.Lectures.First(lc => lc.Name.Equals("Math"));
            Lecture History = context.Lectures.First(lc => lc.Name.Equals("History"));
            Lecture Geography = context.Lectures.First(lc => lc.Name.Equals("Geography"));

            context.Student_Lectures.InsertOnSubmit(new Student_Lecture {Student = Carla, Lecture = Math });
            context.Student_Lectures.InsertOnSubmit(new Student_Lecture { Student = Toni, Lecture = History});

            Student_Lecture slToni = new Student_Lecture();
            slToni.Student = Toni;
            slToni.LectureId = History.Id;
            context.Student_Lectures.InsertOnSubmit(slToni);

            context.Student_Lectures.InsertOnSubmit(new Student_Lecture { Student = Layla, Lecture = Geography });

            context.SubmitChanges();

            DataGridId.ItemsSource = context.Student_Lectures;
        }

        public void GetUniversityOfToni()
        {
            Student Toni = context.Students.First(st => st.Name.Equals("Toni"));

            University ToniUniversity = Toni.University;

            List<University> universities = new List<University>();
            universities.Add(ToniUniversity);

            DataGridId.ItemsSource = universities;
        }

        public void GetLecturesOfToni()

        {
            Student Toni = context.Students.First(st => st.Name.Equals("Toni"));

            var toniLectures = from sl in Toni.Student_Lectures select sl.Lecture;

            DataGridId.ItemsSource = toniLectures;
        }

        public void GetAllStudentsFromYale()
        {
            var studentsFromYale = from student in context.Students
                                   where student.University.Name == "Yale"
                                   select student;

            DataGridId.ItemsSource = studentsFromYale;
        }

        public void AllUniversitiesWithTrans()
        {
            var genderOfTheStudents = from student in context.Students
                                      join university in context.Universities
                                      on student.University equals university
                                      where student.Gender == "trans-gender"
                                      select university;

            DataGridId.ItemsSource = genderOfTheStudents;
        }

        public void GetLecturesFromSpecificUni()
        { 
            var beijingLectures = from lecture in context.Student_Lectures
                                  join student in context.Students
                                  on lecture.StudentId equals student.Id
                                  where student.University.Name == "Beijing Tech"
                                  select lecture;

            DataGridId.ItemsSource = beijingLectures;
        }

        public void UpdateToni()
        { 
            Student Toni = context.Students.FirstOrDefault(st => st.Name.Equals("Toni"));

            Toni.Name = "Antonio";

            context.SubmitChanges();

            DataGridId.ItemsSource = context.Students;
        }

        public void DeleteAnn()
        {
            Student Ann = context.Students.FirstOrDefault(st => st.Name.Equals("Ann"));
            context.Students.DeleteOnSubmit(Ann);
            context.SubmitChanges();

            string connectionString = ConfigurationManager.ConnectionStrings["LINQ_TO_SQL.Properties.Settings.Database_TutorialConnectionString"].ConnectionString;

            LinqToSQLDataContext dataBase = new LinqToSQLDataContext(connectionString);

            DataGridId.ItemsSource = dataBase.Students;
        }
    }
}
