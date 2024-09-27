using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newFile
{
    class Person
    {
        public string Name = "Suresh";
        public int Age = 21;

    }
    class Student : Person
    {
        public  Student()
        {
            Console.WriteLine("Student Name is =" + Name + "\nStudent Age is  =" + Age); 
        }
    }
    internal class singleInheritance
    {
        static void Main()
        {
            Student s1 = new Student();
            
        }
    }
}
