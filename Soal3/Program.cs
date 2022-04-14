using System;

namespace Soal3
{
    public class DrawingObject
    {
        public virtual void Draw()
        {
            Console.WriteLine("I'm just a generic drawing object.");
        }
    }

    public class Line: DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Line.");
        }
    }
    public class Circle: DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Circle.");
        }
    }
    public class Square: DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("I'm a Square.");
        }
    }


    public class DrawDemo
    {
        public static int Main()
        {
            DrawingObject[] objects = new DrawingObject[4];

            objects[0] = new Line();
            objects[1] = new Circle();
            objects[2] = new Square();
            objects[3] = new DrawingObject();

            foreach (DrawingObject item in objects)
            {
                item.Draw();
            }

            return 0;
        }
    }
}
