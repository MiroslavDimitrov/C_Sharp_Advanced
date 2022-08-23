using System;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            UniversityManager universityManager = new UniversityManager();
            universityManager.FilterStudentsAndUniversities();
            universityManager.PrintMaleStudents();
            universityManager.PrintFemaleStudents();
            universityManager.SortStudentsByAge();
            universityManager.SortAllStudentsFromTech();
            int Id = int.Parse(Console.ReadLine());
            universityManager.PrintStudents(Id);
        }
    }

    class University
    {
        public int ID { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string UniversityName { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public void Print()
        {
            Console.WriteLine("University {0} with ID {1}", UniversityName, ID);
        }
    }

    class Student
    {
        public int ID { get; set; }
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Name { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public string Gender { get; set; }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public int Age { get; set; }

        public int UniversityId { get; set; }

        public void Print()
        {
            Console.WriteLine("Student {0} with ID {1}, gender {2} and age {3} from the university with ID {4}.", Name, ID, Gender, Age, UniversityId);
        }
    }

    class UniversityManager
    {
        public List<University> universities;
        public List<Student> students;
        public UniversityManager()
        {
            universities = new List<University>();
            students = new List<Student>();

            universities.Add(new University { ID = 1, UniversityName = "Yale"});
            universities.Add(new University { ID = 2, UniversityName = "Beijing Tech"});

            students = new List<Student>
            {
                new Student { ID = 1, Name = "Carla", Gender = "female", Age = 17, UniversityId = 1 },
                new Student { ID = 2, Name = "Tony", Gender = "male", Age = 21, UniversityId = 1 },
                new Student { ID = 3, Name = "Layla", Gender = "female", Age = 19, UniversityId = 1 },
                new Student { ID = 4, Name = "James", Gender = "trans-gender", Age = 25, UniversityId = 2 },
                new Student { ID = 5, Name = "Linda", Gender = "female", Age = 22, UniversityId = 2 },
                new Student { ID = 6, Name = "Peter", Gender = "male", Age = 18, UniversityId = 2 },
                new Student { ID = 7, Name = "Eva", Gender = "female", Age = 20, UniversityId = 2 }
            };
        }

        public void PrintMaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in students where student.Gender == "male" select student;
            Console.WriteLine("Male students: ");
            foreach (Student student in maleStudents)
            {
                student.Print();
            }

            Console.WriteLine();
        }

        public void PrintFemaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in students where student.Gender == "female" select student;
            Console.WriteLine("Male students: ");
            foreach (Student student in femaleStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void SortStudentsByAge()
        {
            var sortedStudents = from student in students orderby student.Age select student;

            Console.WriteLine("Student sorted by age: ");

            foreach (Student student in sortedStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void SortAllStudentsFromTech()
        { 
            IEnumerable<Student> bjtStudents = from student in students 
                                               join university in universities
                                               on student.UniversityId equals university.ID
                                               where university.UniversityName == "Beijing Tech"
                                               select student;

            Console.WriteLine("Students from Beijing: ");
            foreach (Student student in bjtStudents)
            {
                student.Print();
            }
            Console.WriteLine();
        }

        public void PrintStudents(int id)
        {

           
           
            if (id == 1)
            {
                IEnumerable<Student> yaleStudents = from student in students
                                                    join university in universities
                                                    on student.UniversityId equals university.ID
                                                    where university.UniversityName == "Yale"
                                                    select student;

                Console.WriteLine("Students from university with ID {0} are: ", id);
                foreach (Student student in yaleStudents)
                {
                    student.Print();
                }
                Console.WriteLine();
            }
            else if (id == 2)
            {
                IEnumerable<Student> yaleStudents = from student in students
                                                    join university in universities
                                                    on student.UniversityId equals university.ID
                                                    where university.UniversityName == "Beijing Tech"
                                                    select student;

                Console.WriteLine("Students from university with ID {0} are: ", id);
                foreach (Student student in yaleStudents)
                {
                    student.Print();
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There is no university with that ID!");
            }
        }

        public void FilterStudentsAndUniversities()
        {
            var sorted = from student in students
                         join university in universities on student.UniversityId equals university.ID
                         orderby student.Name
                         select new { StudentName = student.Name, StudentUniversity = university.UniversityName };

            Console.WriteLine("New collection: ");

            foreach (var item in sorted)
            {
                Console.WriteLine("Student {0} from university {1}.", item.StudentName, item.StudentUniversity);
            }
            Console.WriteLine();
        }
    }
}

