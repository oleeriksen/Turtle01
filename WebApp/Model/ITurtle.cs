namespace WebApp.Model
{
    public interface ITurtle
    {
        void Down();
        void Move(double distance);
        void MoveTo(double x, double y);
        void Reset();
        void Turn(double d);
        void TurnTo(double d);
        void Up();
        string Color { get; set; }
        double Width { get; set; }
    }
}