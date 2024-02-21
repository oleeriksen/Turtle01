using System;
using WebApp.Model;
namespace WebApp.Drawings
{
    public class RandomDrawing
    {

        public void DrawRandom(ITurtle t, int steps) {
            t.Up();
            t.MoveTo(500, 300);
            t.Down();
            t.Move(100);

        }

    }
}

