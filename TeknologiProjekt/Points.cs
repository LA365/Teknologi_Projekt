using System;
using System.Collections.Generic;
using System.Text;

namespace TeknologiProjekt
{
    public static class Points
    {
        private static int _points = 0;
        private static readonly object _lock = new object();

        public static void AddPoints()
        {
            lock (_lock)
            {
                _points++;
            }
        }

        public static void RemovePoints(int number)
        {
            lock(_lock)
            {
                _points -= number;
            }
        }
        public static int GetPoints()
        {
            return _points;
        }
    }
}
