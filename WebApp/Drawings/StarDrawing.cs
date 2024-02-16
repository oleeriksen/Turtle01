﻿using System;
using WebApp.Model;

namespace WebApp.Drawings
{
	public class StarDrawing
	{
        /// <summary>
        /// Draw [n] stars of random size and location using
        /// the turtle [t]
        /// </summary>
        /// <param name="t">The turtle to draw with</param>
        /// <param name="n">The number of stars</param>
        public void DrawManyStars(ITurtle t, int n)
        {
            string[] colors = { "red", "black", "green", "blue", "yellow", "white" };
            Random r = new Random();
            t.Width = 1;

            for (int i = 0; i < n; i++)
            {
                int size = 50 + r.Next(100);
                int cx = size + r.Next(1000 - 2*size);
                int cy = size + r.Next(600 - 2*size);
                string color = colors[r.Next(colors.Length)];
                
                DrawOneStar(t, cx, cy, size, color);
            }

        }

        public void DrawOneStar(ITurtle t, double cx, double cy, int size, string color) {

            t.Up();
            t.MoveTo(cx, cy);
            t.TurnTo(0);
            t.Down();
            t.Width = 1;
            t.Color = color;
           
            for (int i = 0; i < 36; i++)
            {           
                t.Move(size);
                t.Up();
                t.MoveTo(cx, cy);
                t.Turn(10);
                t.Down();
            }
        }

        public void DrawStar_old(ITurtle t, int n)
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
                t.Turn(360.0 / n);
                t.Down();
            }

        }
    }
}

