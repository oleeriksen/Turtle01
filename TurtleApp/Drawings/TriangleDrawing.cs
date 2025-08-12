using System;
using TurtleApp.Model;

namespace TurtleApp.Drawings
{
	public class TriangleDrawing
	{
		public TriangleDrawing()
		{
		}

        public void DrawTriangle(ITurtle t, double width, int level)
        {
            var nw = width / 3;
            if (level == 0 || nw <= 3)
                t.Move(width);
            else
            {
                
                DrawTriangle(t, nw, level - 1);
                t.Turn(-60);
                DrawTriangle(t, nw, level - 1);
                t.Turn(120);
                DrawTriangle(t, nw, level - 1);
                t.Turn(-60);
                DrawTriangle(t, nw, level - 1);
            }
        }
    }
}

