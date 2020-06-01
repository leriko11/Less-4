using System;
using System.Collections.Generic;
using System.Text;

namespace Les_4
{
    class Rectangle : IShape
    {
        private double _a = 0;
        private double _b = 0;
        private double _c = 0;
        private double _d = 0;

        private double _p = 0;

        public Rectangle()
        {
           
        }

        public Rectangle(ArrayofXY arrayofXYSides_1, ArrayofXY arrayofXYSides_2, ArrayofXY arrayofXYSides_3, ArrayofXY arrayofXYSides_4)
        {
            this._a = Math.Sqrt((arrayofXYSides_1.x * arrayofXYSides_1.x) + (arrayofXYSides_1.y * arrayofXYSides_1.y));
            this._b = Math.Sqrt((arrayofXYSides_2.x * arrayofXYSides_2.x) + (arrayofXYSides_2.y * arrayofXYSides_2.y));
            this._c = Math.Sqrt((arrayofXYSides_3.x * arrayofXYSides_3.x) + (arrayofXYSides_3.y * arrayofXYSides_3.y));
            this._d = Math.Sqrt((arrayofXYSides_4.x * arrayofXYSides_4.x) + (arrayofXYSides_4.y * arrayofXYSides_4.y));

            _p = (this._a + this._b + this._c + this._d) / 2;
        }

        public double Area()
        {
            return Math.Sqrt((_p - this._a) * (_p - this._b) * (_p - this._c) * (_p - this._d));
        }

        public double Perimeter()
        {
            return this._a + this._b + this._c + this._d;
        }
    }
}
