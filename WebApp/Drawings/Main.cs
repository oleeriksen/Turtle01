using System;
using WebApp.Model;

namespace WebApp.Drawings
{
    public class Main
    {
        public static void Run() {
            ITurtle t = new Turtle();
            DrawStar(t, 36);
        }

        private static void DrawStar(ITurtle t, int n)
        {
            double centerX = 250, centerY = 150;
            t.Up();
            t.Color = "red";
            t.MoveTo(centerX, centerY);
            t.TurnTo(0);
            t.Down();

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0) //lige tal
                    t.Width = 3;
                else
                    t.Width = 1;
                t.Move(100); // her tegnes
                t.Up();
                t.MoveTo(centerX, centerY);
                t.Turn(360 / n);
                t.Down();
            }

        }

        private static void DrawCubik(ITurtle t, double width, int level)
        {
            if (level == 0)
                t.Move(width);
            else
            {
                var nw = width / 3;
                DrawCubik(t, nw, level - 1);
                t.Turn(-90);
                DrawCubik(t, nw, level - 1);
                t.Turn(90);
                DrawCubik(t, nw, level - 1);
                t.Turn(90);
                DrawCubik(t, nw, level - 1);
                t.Turn(-90);
                DrawCubik(t, nw, level - 1);
            }
        }

        
    }
}

