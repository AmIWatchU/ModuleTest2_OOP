using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleTest2_OOP
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


        struct Rectangle
        {
            public double xy;
            public double xy1;
            public string color;
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
      
        struct Window
        {
            public string Title;
            public string[] Menu;
        public Window(string Title, string[] Menu)
        {
            this.Title = Title;
            this.Menu = Menu;         
        }
        public void DisplayInfo()
        {
            if (Menu == null || string.IsNullOrEmpty(Title))
            {
                return;
            }
            
            Console.Write($"Title: {Title} Menu: ");
            foreach (var a in Menu)
            {
                Console.Write(a + " ");
            }
        }
    } 


   

    struct StructList
    {
        
        public Rectangle[] Rectangles;
        public Window[] Windows;
        private int RectCounter;
        private int WindowCounter;

        public StructList(int rectangles, int windows)
        {
            Rectangles = new Rectangle[rectangles];
            Windows = new Window[windows];
            RectCounter = 0;
            WindowCounter = 0;
        }

        public void AddRect(Rectangle rect) 
        {
            Rectangles[RectCounter++] = rect;
        }
        public void AddWindow(Window wind) 
        {
            Windows[WindowCounter++] = wind;
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                StructList sl = new StructList(2, 2);
                Rectangle Rectangle1;
                Rectangle1.xy = 14;
                Rectangle1.xy1 = 34;
                Rectangle1.color = "Black";
                sl.AddRect(Rectangle1);

            Rectangle Rectangle2;
            Rectangle2.xy = 15;
            Rectangle2.xy1 = 23;
            Rectangle2.color = "Red";
            sl.AddRect(Rectangle2);

            Window window;
                window.Title = "ModuleTest";
                window.Menu = new string[] { "File", "Edit", "Git", "Project", "Build", "Debug", "Test", "Analyze" };
                sl.AddWindow(window);
            for (int i = 0; i < sl.Rectangles.Length; i++)
            {
                if (sl.Rectangles[i].color == "Black")
                {
                    sl.Rectangles[i].DisplayInfo();
                }
                   
            }
            for (int i = 0; i < sl.Windows.Length; i++)
            {
                sl.Windows[i].DisplayInfo();
            }
            
            Console.ReadKey();

                
            }
        }
}   
 

    

