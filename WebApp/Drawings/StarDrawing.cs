using System;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class StarDrawing
	{
        public void DrawStar(ITurtle t, int n)
        {
            double centerX = 500, centerY = 300;
            t.Up();
            t.Color = "red";
            t.MoveTo(centerX, centerY);
            t.TurnTo(0);
            t.Down();
            t.Width = 2;

            for (int i = 0; i < n; i++)
            {
                // hver anden skal være kortere og blå
                if (i % 2 == 0) // even
                {
                    t.Color = "blue";
                    t.Move(160);
                    t.Color = "red";
                }
                else
                    t.Move(200);
                t.Up();
                t.MoveTo(centerX, centerY);
                t.Turn(360 / n);
                t.Down();
            }

        }
    }
}

