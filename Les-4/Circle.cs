using System;
using System.Collections.Generic;
using System.Text;

namespace Les_4
{
    class Circle : IShape
    {
        private const double _p = 3.14;
        private double _Radius = 0;

        // Radius by Coordinate Points
        //public Circle(double dX1, double dY1, double dX2, double dY2)
        //{
        //    this._Radius = Math.Sqrt(((dX2 - dX1) * (dX2 - dX1)) + ((dY2 - dY1) * (dY2 - dY1)));
        //}

        // Radius by Coordinate Sides
        public Circle()
        {
            
        }
        public Circle(ArrayofXY arrayofXYSides)
        {
            this._Radius = Math.Sqrt((arrayofXYSides.x * arrayofXYSides.x) + (arrayofXYSides.y * arrayofXYSides.y));
        }

        public double Area()
        {
            return _p * (this._Radius * this._Radius);
        }

        public double Perimeter()
        {
            return 4 * _p * this._Radius;
        }
    }
}
