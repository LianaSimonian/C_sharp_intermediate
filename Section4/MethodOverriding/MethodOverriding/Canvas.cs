using System;
using System.Collections.Generic;


namespace MethodOverriding
{
    internal class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
