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
            catch (OutOfBoundsException ex)
            {
                Debug.WriteLine(ex.Message);
            }
            catch (TreehouseDefenseException)
            {
                Debug.WriteLine("Unhandled TreehouseDefenseException.");
            }
            catch (Exception)
            {
                Debug.WriteLine("Unhandled Exception.");
            }
        }
    }
}