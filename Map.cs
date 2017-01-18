namespace TreehouseDefense
{
    class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            bool inBounds = point.XCoordinate >= 0 && point.XCoordinate < Width && point.YCoordinate >= 0 && point.YCoordinate < Height;

            return inBounds; 
        }
    }
}