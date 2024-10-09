using System;


namespace AbstractClasses
{
    internal abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();
        
        public void Copy()
        {
            Console.WriteLine("copy shape into clipboard .");
        }

        public void Select()
        {
            Console.WriteLine( "select the shape .");
        }
    }
}