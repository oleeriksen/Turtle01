namespace WebApp.Model
{
    public interface ITurtle
    {
        void Down();
        void Up();
        void Move(double distance);
        void MoveTo(double x, double y);
        
        void Turn(double d);
        void TurnTo(double d);
        string Color { get; set; }
        double Width { get; set; }

        void Reset();
    }
}