﻿using System;

namespace Methods
{
    internal class Point
    {
        public int X;
        public int Y;
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Move(int x, int y)
        {
            X = x;
            Y = y;

        }
        public void Move(Point newLocation)
        {if (newLocation == null)
                throw new ArgumentNullException(nameof(newLocation));
            Move(newLocation.X, newLocation.Y);
        }
    }
}

