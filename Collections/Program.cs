// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.Collections.Generic;

namespace C_sharp_advenced
{
    public class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '*';
            string book = "Hobbit";

            //Non-generic collection with undefined amount of objects
            ArrayList arrayList = new ArrayList();
            //with defined amount of objects
            ArrayList arrayListTwo = new ArrayList(200);

            arrayList.Add(at);
            arrayList.Add(price);
            arrayList.Add(pi);
            arrayList.Add(book);

            //remove at specific position
            arrayList.RemoveAt(0);
            //remove specific value
            arrayListTwo.Remove(25.2);

            foreach (object item in arrayList)
            {
                Console.WriteLine(item);
            }

            //declare jagged array with 3 arrays
            int[][] jaggedArray = new int[3][];
            jaggedArray[0] = new int[3];//first --> 0
            jaggedArray[1] = new int[4];//second --> 1
            jaggedArray[2] = new int[5];//third --> 2

            double[] grades = new double[5];
            grades[0] = 2.5;
            grades[1] = 3.5;
            grades[2] = 5.0;
            grades[3] = 5.5;
            grades[4] = 4.2;

            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }

            int[,] twoDArray = new int[,]
            {
            { 0, 1, 5 },//row 1
            { 2, 3, 4 },//row 2
            { 3, 4, 8 },//row 3
            };
            int num = twoDArray[0, 1];
            Console.WriteLine("Yes {0}", num);

            int[] numbers = { 1, 2, 3, 4, 5, 6 };
            //Generic collection
            List<int> nums = new List<int>() { 1, 2, 3 };

            //Hashtabls
            Hashtable studentsTable = new Hashtable();

            Student[] students = new Student[3];
            students[0] = new Student(1, "Maria", 25);
            students[1] = new Student(2, "Georgi", 35);
            students[2] = new Student(3, "Miro", 45);

            //retrieve all values from a Hashtable
            foreach (Student value in students)
            {

                if (!studentsTable.ContainsKey(value.Id))
                {
                    studentsTable.Add(value.Id, value);
                }
                else
                {
                    Console.WriteLine("Sorry. A student with ID: {0} was added!", value.Id);
                }

                Console.WriteLine("Student Id is: {0}", value.Id);
                Console.WriteLine("Student Name: {0}", value.Name);
                Console.WriteLine("Student GPA is: {0}", value.GPA);

                //Dictionaries
                Dictionary<int, string> myDict = new Dictionary<int, string>()
                {
                    {1, "one" },
                    {2, "two" },
                    {3, "three"}
                };

                //array with employees
                Employee[]employees =
                { 
                    new Employee("CEO", "Joro", 95, 180),
                    new Employee("HR", "Maria", 85, 150),
                    new Employee("Manager", "Marina", 45, 55),
                    new Employee("Intern", "Petar", 20, 45),
                    new Employee("Lead Developer", "Anton", 70, 55)
                };

                //new dict. to add the employyes
                Dictionary<string, Employee> myDict2 = new Dictionary<string, Employee>();
                foreach (Employee emp in employees)
                {
                    myDict2.Add(emp.Role, emp);
                    Console.WriteLine(emp.Role);
                }

                //Stacks and Queues
                //Stack --> data can be added/removed from top --> LastInFirstOut
                //Queues --> Data can be added from the rear (back) and removed from the front --> FirstInFirstOut

                //define new Stack
                Stack<int> stack = new Stack<int>();
                stack.Push(1);
                stack.Push(2);
                //print latest item added in the stack
                Console.WriteLine(stack.Peek());

                //define Queue
                Queue<int> queue = new Queue<int>();
                queue.Enqueue(1);
                queue.Enqueue(2);
                //a new item is last item in the queue
                queue.Enqueue(3);
                //remove the first item at the beginning of the queue
                queue.Dequeue();
                //print the first item from the queue
                Console.WriteLine(queue.Peek());


            }
        }
    }

    class Order
    { 
        public int OrderId { get; set; }
        public int OrderQuantity { get; set; }

        public Order(int orderId, int orderQuantity)
        {
            OrderId = orderId;
            OrderQuantity = orderQuantity;
        }

        public void ProcessOrder()
        {
            //print message
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }

    class Employee
    { 
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        { 
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }

    class Student
    { 
        public int Id { get; set; }

        public string Name { get; set; }

        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        { 
            this.Id = id;
            this.Name = name;
            this.GPA = GPA;
        }
    }
}