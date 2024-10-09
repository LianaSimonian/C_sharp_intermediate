using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
            text.Height = 100;
            text.Duplicate();
            Console.WriteLine("Tex's  width and height :"+text.Width +" " + text.Height);
        }
    }
}
