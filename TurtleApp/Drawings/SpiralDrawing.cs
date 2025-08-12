using System;
using TurtleApp.Model;
namespace TurtleApp.Drawings
{
    public class SpiralDrawing
    {
        public void DrawStarWithBoxes(ITurtle t, double size, int amount) {
            double deltaAngle = 90 / amount;
            for (int i = 0; i < amount;i++) {
                DrawSquare(t, size);
                // move to center
                t.Up();
                t.Turn(90);
                t.Move(size / 2);
                t.Turn(90);
                t.Move(size / 2);
                // turn
                t.Turn(deltaAngle);
                t.Turn(-180);
                t.Move(size / 2);
                t.Turn(-90);
                t.Move(size / 2);
                t.Turn(90);
                t.Down();   
            }
        }

        private void DrawSquare(ITurtle t, double size) {
            for (int i = 0; i < 4; i++) {
                t.Turn(90);
                t.Move(size);
            } 
        }

        public void DrawSpiral(ITurtle t, double size, int amount, int rounds) {
            double deltaTilt = (360.0*rounds / amount);
            double deltaSize = size*7 / (8 * amount);
            for (int i = 0; i <= amount; i++)
            {
                DrawSquare(t, size);
                // move to center
                t.Up();
                t.Turn(90);
                t.Move(size / 2);
                t.Turn(90);
                t.Move(size / 2);
                // turn and adjust size
                size -= deltaSize;
                t.Turn(deltaTilt);
                t.Turn(-180);
                t.Move(size / 2);
                t.Turn(-90);
                t.Move(size / 2);
                t.Turn(90);
                t.Down();
            }
        }
    }
}

