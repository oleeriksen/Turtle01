namespace WebApp.Model
{
    public interface ITurtle
    {
        void Down();
        void Move(int distance);
        void MoveTo(int x, int y);
        void Reset();
        void Turn(int d);
        void TurnTo(int d);
        void Up();
    }
}