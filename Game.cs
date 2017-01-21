using System;
using System.Diagnostics;

namespace TreehouseDefense
{
    class Game
    {
        public static void Main()
        {
            Map map = new Map(8, 5);
            try
            {
                MapLocation mapLocation = new MapLocation(8, 5, map);
            }
            catch(Exception)
            {
                Debug.WriteLine("That ain't on the map, bro.");
            }
        }
    }
}