using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureDemo
{
   public  class Student
    {
        public int id;
        string Name;
        string email;
        public Student(int id,string Name,string email)
        {
            this.id = id;
            this.Name = Name;
            this.email = email;

        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, "Kunal", "Kunal@gmail.com");
            Student s1 = new Student(2, "Rohit", "Rohit@gmail.com");
            Student s2 = new Student(3, "Sagar", "Sagar@gmail.com");

            List<Student> students = new List<Student>();

            students.Add(s);
            students.Add(s1);
            students.Add(s2);

           foreach(var student in students)
            {
                Console.WriteLine(student);
            }
           




        }
    }
}
