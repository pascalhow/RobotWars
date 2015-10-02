﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace RobotWars
{
    // class that can draw a grid
    public class Grid
    {
        public Grid()
        {
            // Set some defaults
            Origin = new Point(0, 0);
            GridCellSize = new Size(10, 10);
            HorizontalCells = 1;
            VerticalCells = 1;
        }

        public int HorizontalCells { get; set; }
        public int VerticalCells { get; set; }
        public Point Origin { get; set; }
        public Size GridCellSize { get; set; }

        public virtual void Draw(Graphics Graf, Pen pencil)
        {
            Point startP = new Point();
            Point endP = new Point();
            // Draw horizontals
            startP.Y = Origin.Y;
            endP.Y = Origin.Y + VerticalCells * GridCellSize.Height;
            for (int i = 0; i <= HorizontalCells; i++)
            {
                startP.X = Origin.X + i * GridCellSize.Width;
                endP.X = startP.X;
                Graf.DrawLine(pencil, startP, endP);
            }
            // Draw verticals
            startP.X = Origin.X;
            endP.X = Origin.X + HorizontalCells * GridCellSize.Width;
            for (int i = 0; i <= VerticalCells; i++)
            {
                startP.Y = Origin.Y + i * GridCellSize.Height;
                endP.Y = startP.Y;
                Graf.DrawLine(pencil, startP, endP);
            }
        }
    }
}
