using System;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);

            //upcasting
            StreamReader reader = new StreamReader(new MemoryStream());

            var list  = new List<Shape>();
            list.Add(new Text());
            list.Add(new Shape());

            //downcasting
            Shape shape1 = new Text(); 
            Text text1 = (Text)shape1;
            
        }
    }
}
