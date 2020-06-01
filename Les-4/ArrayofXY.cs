using System;
using System.Collections.Generic;
using System.Text;

namespace Les_4
{
    class ArrayofXY
    {
        public double x = 0;
        public double y = 0;

        public static ArrayofXY operator -(ArrayofXY arrayofXY_1, ArrayofXY arrayofXY_2)
        {
            var newArrayofXY = new ArrayofXY();
            newArrayofXY = new ArrayofXY() { x = arrayofXY_1.x - arrayofXY_2.x, y = arrayofXY_1.y - arrayofXY_2.y };

            return newArrayofXY;
        }

        public static ArrayofXY operator +(ArrayofXY arrayofXY_1, ArrayofXY arrayofXY_2)
        {
            var newArrayofXY = new ArrayofXY();
            newArrayofXY = new ArrayofXY() { x = arrayofXY_1.x + arrayofXY_1.y };

            return newArrayofXY;
        }
    }
}
