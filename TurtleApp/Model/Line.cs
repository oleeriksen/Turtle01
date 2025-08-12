using System;
namespace TurtleApp.Model
{
    public class Line
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public string Color { get; set; } = "black";
        public double Width { get; set; } = 1;
        
    }
}

