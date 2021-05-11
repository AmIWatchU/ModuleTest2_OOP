using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloApp
{
    struct Rectangle
    {
        public string name;
        public int age;
        public Rectangle(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}  Age: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle One = new Rectangle("Tom", 34);
            One.DisplayInfo();

            Rectangle bob = new Rectangle("Bob", 44);
            bob.DisplayInfo();

            Console.ReadKey();
        }
    }
}