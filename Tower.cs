using System;
using System.Diagnostics;

namespace TreehouseDefense
{
    class Tower
    {
        private readonly MapLocation _location;

        private const int _range = 1;
        private const int _damage = 1;
        private const double _accuracy = 0.75;

        private static readonly System.Random _random = new System.Random();

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

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }

        public void FireOnInvaders(Invader[] invaders)
        {
            foreach(Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if(IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_damage);
                        Debug.WriteLine("Invader successfuly hit!");
                        if(invader.IsNeutralized)
                        {
                            Debug.WriteLine("Invader down!");
                        }
                    }
                    else
                    {
                        Debug.WriteLine("Missed the invader!");
                    }
                    break;
                }
            }
        }
    }
}