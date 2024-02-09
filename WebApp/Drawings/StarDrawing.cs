using System;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class StarDrawing
	{
        public void DrawStar(ITurtle t, int n)
        {
            double centerX = 250, centerY = 150;
            t.Up();
            t.Color = "red";
            t.MoveTo(centerX, centerY);
            t.TurnTo(0);
            t.Down();
            t.Width = 2;

         

            for (int i = 0; i < n; i++)
            {
                t.Move(100); // her tegnes
                t.Up();
                t.MoveTo(centerX, centerY);
                t.Turn(360 / n);
                t.Down();
            }

        }
    }
}

