using System;
using WebApp.Model;

namespace WebApp.Drawings
{
    public class Main
    {
        public static void Run() {
            ITurtle t = new Turtle();
            t.MoveTo(0, 300);
            DrawTriangle(t, 500, 2);
        }

        private static void DrawStar(ITurtle t, int n)
        {
            t.Up();
            t.Color = "red";
            t.MoveTo(200, 200);
            t.TurnTo(0);
            t.Down();

            for (int i = 0; i < n; i++)
            {
                t.Move(100); // her tegnes
                t.Up();
                t.MoveTo(200, 200);
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

        private static void DrawTriangle(ITurtle t, double width, int level)
        {
            if (level == 0)
                t.Move(width);
            else
            {
                var nw = width / 3;
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

