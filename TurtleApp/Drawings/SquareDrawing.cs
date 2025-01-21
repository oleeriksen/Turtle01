using System;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class SquareDrawing
	{
        public void DrawSquare(ITurtle t, double width, int level)
        {
            if (level == 0)
                t.Move(width);
            else
            {
                var nw = width / 3;
                DrawSquare(t, nw, level - 1);
                t.Turn(-90);
                DrawSquare(t, nw, level - 1);
                t.Turn(90);
                DrawSquare(t, nw, level - 1);
                t.Turn(90);
                DrawSquare(t, nw, level - 1);
                t.Turn(-90);
                DrawSquare(t, nw, level - 1);
            }
        }
    }
}

