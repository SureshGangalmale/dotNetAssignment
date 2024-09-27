using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newFile
{
    public class PErson
    {
        public string name;
        public int Age;
    }
    public class Teacher:PErson
    {
        public int id;
        public int salary;
    }
    public class Principle:Teacher
    {
        public Principle(int id, string Name, int Age, int salary)
        {
              this.id = id;
              this.name = Name;
              this.Age = Age;
              this.salary = salary;

            Console.WriteLine("Id=" + id + "\nName=" + name + "\nAge=" + Age + "\nSalary=" + salary);
        }
    }
    internal class multilevelInheritance
    {
        static void Main()
        {
            Principle p = new Principle(201, "Amol", 20, 40000);
        }
    }
}
