namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

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
            int index = 0;

            while(index < invaders.Length)
            {
                Invader invader = invaders[index];
                //do stuff with invaders

                index++;
            }
        }
    }
}