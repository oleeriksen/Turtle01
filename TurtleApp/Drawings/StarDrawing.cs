using System;
using TurtleApp.Model;

namespace TurtleApp.Drawings
{
	public class StarDrawing
	{
        public void DrawOneStar(ITurtle t)
        {
            double size = 200; 
            double cx = 500; 
            double cy = 300;
            // (center for stjernen er (cx,cy)
            
            
            t.Up();
            t.MoveTo(cx, cy);
            t.TurnTo(0);
            t.Down();
            t.Width = 2;
           
            for (int i = 0; i < 36; i++)
            {           
                t.Move(size);
                t.Up();
                t.MoveTo(cx, cy);
                t.Turn(10);
                t.Down();
            }
        }
        
        /// <summary>
        /// Draw [n] stars of random size and location using
        /// the turtle [t]
        /// </summary>
        /// <param name="t">The turtle to draw with</param>
        /// <param name="n">The number of stars</param>
        public void DrawManyStars(ITurtle t, int n)
        {
            Random r = new Random();
            string[] colors = {"red", "blue", "black", "gray", "yellow", "green"} ;
            t.Width = 1;

            for (int i = 0; i < n; i++)
            {
                int size = 50 + r.Next(100);
                int cx = size + r.Next(1000 - 2*size);
                int cy = size + r.Next(600 - 2*size);
                int randomIdx = r.Next(colors.Length);
                string randomColor = colors[randomIdx];
                DrawOneStar(t, size, cx, cy, randomColor);
            }
        }
        
        private void DrawOneStar(ITurtle t, double size, double cx, double cy, string color)
        {
            t.Color = color;
            t.Up();
            t.MoveTo(cx, cy);
            t.TurnTo(0);
            t.Down();
            t.Width = 1;
           
            for (int i = 0; i < 36; i++)
            {           
                t.Move(size);
                t.Up();
                t.MoveTo(cx, cy);
                t.Turn(10);
                t.Down();
            }
        }
    }
}

