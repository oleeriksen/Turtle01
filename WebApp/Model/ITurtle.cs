namespace WebApp.Model
{
    public interface ITurtle
    {
        /* Represent an object that can move in a 2D world.
          The state is:
           - the current loation -- (0,0) default
           - the current direction -- 0 default
           - a switch for traceability - on defsult
           - a width - 1 default */

        // set traceability to on
        void Down();

        // set traceability to off
        void Up();

        // move in the current direction
        void Move(double distance);

        // moveto a specific coordinate
        void MoveTo(double x, double y);

        // add d to direction
        void Turn(double d);

        // set direction
        void TurnTo(double d);

        // The color
        string Color { get; set; }

        // The width
        double Width { get; set; }

        // Reset state
        void Reset();
    }
}