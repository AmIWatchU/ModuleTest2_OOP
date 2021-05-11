using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloApp
{
    //Bаріант 4
    //1. створити структуру прямокутник, що має координати верхнього лівого і
    //нижнього правого кута, колір фону.
    //2. створити структуру - вікно, яка має заголовок та рядок меню (масив рядків з
    //назвами команд меню).
    //3. розробити структуру список вікон, що містить масив структур
    //прямокутник та вікно.
    //4. вивести на екран список вікон заданого кольору
    //5. створити програму для тестування.

    interface IShape
    {
        void DisplayInfo();
      string color { get; set; }
    }
    struct Rectangle:IShape
    {
        public double xy;
        public double xy1;
        public string color{ get; set;}
        public Rectangle(string color, double xy, double xy1)
        {
            this.xy = xy;
            this.xy1 = xy1;
            this.color = color;
        }

        public void DisplayInfo()
        {
            if (string.IsNullOrEmpty(color))
            {
                return;
            }
            Console.WriteLine($"First coordinate: {xy} Second coordinate: {xy1} Color: {color}");
        }

    }

    struct Window:IShape
    {
        public string Title;
        public string[] Menu;
        public string color { get; set; }
        public Window(string Title, string[] Menu, string color)
        {
            this.Title = Title;
            this.Menu = Menu;
            this.color = color;
        }
        public void DisplayInfo()
        {
            if (Menu == null || string.IsNullOrEmpty(Title))
            {
                return;
            }

            Console.Write($"Title: {Title} Color: {color} Menu: ");
            foreach (var a in Menu)
            {
                Console.Write(a + " ");
            }
        }
    }




    struct StructList
    {

        public IShape[] Shapes;
        private int ShapeCounter;

        public StructList(int Shapes)
        {
            this.Shapes = new IShape[Shapes];
            ShapeCounter = 0;
        }

        public void AddShape(IShape shp)
        {
            Shapes[ShapeCounter++] = shp;
        }
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            StructList sl = new StructList(2);
            Rectangle Rectangle1 = new Rectangle("Black", 14, 34);
            sl.AddShape(Rectangle1);

            Window window = new Window("ModuleTest",
                new string[] { "File", "Edit", "Git", "Project", "Build", "Debug", "Test", "Analyze" },
                "Red");
            sl.AddShape(window);
            for (int i = 0; i < sl.Shapes.Length; i++)
            {
                if (sl.Shapes[i].color == "Red")
                {
                    sl.Shapes[i].DisplayInfo();
                }
                
            }


            Console.ReadKey();


        }
    }
    
}