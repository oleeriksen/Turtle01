using System;
using TurtleApp.Model;
namespace TurtleApp.Drawings
{
    public class RandomDrawing
    {

        public void DrawRandom(ITurtle t, int steps) {
            Dice distance = new Dice(30);
            Dice direction = new Dice(180);
            Dice width = new Dice();
            string[] colors = { "black", "red", "green", "blue" };
            Dice color = new Dice(colors.Length);

            t.Up();
            t.MoveTo(500, 300);
            t.Down();

            for (int i = 0; i < steps; i++)
            {
                distance.Roll();
                direction.Roll();
                width.Roll();
                color.Roll();
                t.Turn(direction.Eyes() - 90);
                t.Width = width.Eyes();
                t.Color = colors[color.Eyes() - 1];
                t.Move(distance.Eyes());
                
            }


        }

    }
}

