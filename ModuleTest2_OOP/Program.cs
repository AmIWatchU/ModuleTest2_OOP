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
            
        }
        class Program
        {
            static void Main(string[] args)
            {
                Rectangle Rectangle1;
                Rectangle1.xy = 14;
                Rectangle1.xy1 = 34;
                Rectangle1.color = "Black";
            }
        }

        struct Window
        {
            public string Title;
            public string[] Menu;
        }
    class Program1
    {
        static void Main(string[] args)
        {
            Window window;
            window.Title = "ModuleTest";
            window.Menu = new string[] {"File", "Edit", "Git", "Project", "Build", "Debug"};            
        }
    }

    struct List
        {

        }


    }   
 

    

