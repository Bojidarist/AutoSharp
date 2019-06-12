namespace AutoSharp
{
    public class CursorCoordinates
    {
        public int X { get; }
        public int Y { get; }

        public CursorCoordinates(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public override string ToString()
        {
            return $"X: { this.X }  |   Y: { this.Y }";
        }
    }
}
