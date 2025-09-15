using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_demo
{
    internal class Class1
    {
       private  int studentId;
        string studentName;
        int age;
        string contactNo;
        string emailId;

        public void initialize()
        {
            studentId = 10;
            studentName = "John";
        }

        public void display()
        {
            Console.WriteLine("Student Id: " + studentId);
            Console.WriteLine("Student Name: " + studentName);
        }

        public Class1(int studentId, string studentName, int age, string contactNo, string emailId)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.age = age;
            this.contactNo = contactNo;
            this.emailId = emailId;
        }

       
    }
}
