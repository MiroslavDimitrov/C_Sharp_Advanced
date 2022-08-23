using System;
using System.Xml.Linq;

namespace C_sharp_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentsXML =
                @"<Students>
                    <Student>
                        <Name>Toni</Name>
                        <Age>21</Age>
                        <University>Yale</University>
                        <Semester>6</Semester>
                    </Student>
                    <Student>
                        <Name>Valya</Name>
                        <Age>25</Age>
                        <University>Yale</University>
                        <Semester>4</Semester>
                    </Student>
                    <Student>
                        <Name>Ina</Name>
                        <Age>24</Age>
                        <University>Yale</University>
                        <Semester>2</Semester>
                    </Student>
                </Students>";

            XDocument xmlDocument = new XDocument();

            xmlDocument = XDocument.Parse(studentsXML);

            var students = from student in xmlDocument.Descendants("Student")
                           select new
                           {
                               Name = student.Element("Name").Value,
                               Age = student.Element("Age").Value,
                               University = student.Element("University").Value,
                               Semester = student.Element("Semester").Value
                           };

            foreach (var student in students)
            {
                Console.WriteLine("Student {0} with age {1} and university {2} for {3} semesters.", student.Name, student.Age, student.University, student.Semester);
            }
            Console.WriteLine();

            var studentsAge = from student in students orderby student.Age select student;
                              

            foreach (var student in studentsAge)
            {
                Console.WriteLine("Student {0} with age {1} and university {2} for {3} semesters.", student.Name, student.Age, student.University, student.Semester);
            }
        }
    }
}