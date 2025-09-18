using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Data_structure_Assignment
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int marks { get; set; }

        public Student(int Id,string Name,int marks) {
            this.Id = Id;
            this.Name = Name;
            this.marks = marks;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //List Example
            List<Student> students = new List<Student>();

            // Add Student objects to the list
            Student first = new Student(1, "Alice", 10);
            Student second = new Student(2, "Bob", 90);
            Student third = new Student(3, "Charlie", 78);
            students.Add(first);
            students.Add(second);
            students.Add(third);


            // Access and display each student using foreach
            Console.WriteLine("Student List:");
            foreach (Student s in students)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Marks: {s.marks}");
            }

            // Access a specific object by index
            Console.WriteLine($"\nSecond student is: {students[1].Name}");

            //Dictionay Example
            Dictionary<string, Student> students_dict = new Dictionary<string, Student>();
            students_dict.Add("firstStudent", first);
            students_dict.Add("seondStudent", second);
            students_dict.Add("thirdStudent", third);


            foreach (KeyValuePair<string, Student> student in students_dict)
            {
                Console.WriteLine($"ID: {student.Value.Id}, Name: {student.Value.Name}, Marks: {student.Value.marks}");
            }


            //Hashset Example
            Console.WriteLine("Hashset demo");
            HashSet<Student> students_hashset = new HashSet<Student>();
            students_hashset.Add(first);
            students_hashset.Add(second);
            students_hashset.Add(first);
            students_hashset.Add(third);

            foreach (Student s in students_hashset)
            {
                Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Marks: {s.marks}");
            }


            //StackDemo


            Stack<Student> students_stack = new Stack<Student>();
            students_stack.Push(first);
            students_stack.Push(second);
            students_stack.Push(third);

            Student pop_stack = students_stack.Pop();
            Console.WriteLine(pop_stack.Name);


            //Queue demo
            Console.WriteLine("Queue demo");
            Queue<Student> students_queue = new Queue<Student>();
            students_queue.Enqueue(first);
            students_queue.Enqueue(second);
            students_queue.Enqueue(third);

            Console.WriteLine(students_queue.Dequeue().Name);
            //LInked list 
            Console.WriteLine("Linked List");
            LinkedList<Student> students_list = new LinkedList<Student>();
           students_list.AddFirst(first);
            students_list.AddAfter(students_list.First,second);
            students_list.AddLast(third);

            foreach (Student s in students_list)
            {
                Console.WriteLine($"Id:{s.Id},Name: {s.Name}, Marks: {s.marks}");
                

            }



            Console.WriteLine("Tupple");
            List<Tuple<int, string, int>> student_tuple = new List<Tuple<int, string, int>>();

            Tuple<int, string, int> st1 = new Tuple<int, string, int>(1, "Alice", 10);
            Tuple<int, string, int> st2 = new Tuple<int, string, int>(2, "John", 20);
            Tuple<int, string, int> st3 = new Tuple<int, string, int>(3, "Bob", 30);

            student_tuple.Add(st1);
            student_tuple.Add(st2);
            student_tuple.Add(st3);

            foreach (Tuple<int, string, int> s in student_tuple)
            {
                Console.WriteLine($"ID: {s.Item1}, Name: {s.Item2}, Marks: {s.Item3}");
            }



        }
    }
}
