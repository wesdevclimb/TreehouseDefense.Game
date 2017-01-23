namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        private const int _range = 1;
        private const int _damage = 1;

        public Tower(MapLocation location, Path path)
        {
            if(!path.OnPath(location))
            {
                _location = location;
            }
            else
            {
                throw new OutOfBoundsException("(" + location.X + ", " + location.Y + ") is not a valid location for the tower.");
            }
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    invader.DecreaseHealth(_damage);
                    break;
                }
            }
        }
    }
}