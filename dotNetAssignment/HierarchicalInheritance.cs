using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newFile
{
    public class Shape1
    {
        public string color;
        public void DisplayDetais()
        {
            Console.WriteLine(color);
        }
    }
    public class Circle1 : Shape1
    {
        public Circle1(string color)
        {
            this.color= color;
        }
    }
    public class Rectangle1:Shape1
    {
        public Rectangle1(string color)
        {
            this.color = color;
        }
    }
    internal class HierarchicalInheritance
    {

        static void Main()
        {
            Circle1 circle = new Circle1("White");
            Console.Write("Circle color : ");
            circle.DisplayDetais();
            Rectangle1 rectangle = new Rectangle1("blue");
            Console.Write("Rectangle color:");
            rectangle.DisplayDetais();

        }
    }
}
