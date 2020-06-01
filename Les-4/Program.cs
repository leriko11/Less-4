using System;

namespace Les_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle myShape_1 = new Circle();
            Triangle myShape_2 = new Triangle();
            Rectangle myShape_3 = new Rectangle();

            while (true)
            {
                Console.WriteLine("Airchiet Geometriuli Figura");
                Console.WriteLine();
                Console.WriteLine("     Tsretsiri:      1");
                Console.WriteLine("     Samkutxedi:     2");
                Console.WriteLine("     Otxkutxedi:     3");
                Console.WriteLine("     Otxkutxedi:     4");
                Console.WriteLine("     Exit:           0");
                Console.WriteLine();

                var nFigure = Convert.ToInt32(Console.ReadLine());

                // Tsretsiri
                if (nFigure == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Shemoitanet Tsretsiris Koordinatebi");
                    Console.WriteLine();

                    ArrayofXY[] xyArrayCircle = new ArrayofXY[2];

                    Console.WriteLine("X1 - Y1");
                    xyArrayCircle[0] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("X2 - Y2");
                    xyArrayCircle[1] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("(X1:Y1) - " + xyArrayCircle[0].x.ToString() + ":" + xyArrayCircle[0].y.ToString());
                    Console.WriteLine("(X2:Y2) - " + xyArrayCircle[1].x.ToString() + ":" + xyArrayCircle[1].y.ToString());
                    Console.WriteLine();

                    myShape_1 = new Circle(xyArrayCircle[1] - xyArrayCircle[0]);

                    Console.WriteLine("Tsretsiris Perimetri = " + myShape_1.Perimeter());
                    Console.WriteLine("Tsretsiris Fartobia = " + myShape_1.Area());

                    Console.WriteLine();
                    continue;
                }
                // Samkutxedi
                else if (nFigure == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Shemoitanet Samkutxedis Koordinatebi");
                    Console.WriteLine();

                    ArrayofXY[] xyArrayTriangle = new ArrayofXY[3];

                    Console.WriteLine("X1 - Y1");
                    xyArrayTriangle[0] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("X2 - Y2");
                    xyArrayTriangle[1] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("X3 - Y3");
                    xyArrayTriangle[2] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("(X1:Y1) - " + xyArrayTriangle[0].x.ToString() + ":" + xyArrayTriangle[0].y.ToString());
                    Console.WriteLine("(X2:Y2) - " + xyArrayTriangle[1].x.ToString() + ":" + xyArrayTriangle[1].y.ToString());
                    Console.WriteLine("(X3:Y3) - " + xyArrayTriangle[2].x.ToString() + ":" + xyArrayTriangle[2].y.ToString());

                    //Triangle myShape = new Triangle(xyArray[0].x, xyArray[0].y, xyArray[1].x, xyArray[1].y, xyArray[2].x, xyArray[2].y);
                    myShape_2 = new Triangle(xyArrayTriangle[1] - xyArrayTriangle[0], xyArrayTriangle[2] - xyArrayTriangle[1], xyArrayTriangle[0] - xyArrayTriangle[2]);

                    Console.WriteLine("Samkutxedis Perimetri = " + myShape_2.Perimeter());
                    Console.WriteLine("Samkutxedis Fartobia = " + myShape_2.Area());

                    Console.WriteLine();
                    continue;
                }
                // Otxkutxedi
                else if (nFigure == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Shemoitanet Samkutxedis Koordinatebi");
                    Console.WriteLine();

                    ArrayofXY[] xyArrayRectangle = new ArrayofXY[4];
                    
                    Console.WriteLine("X1 - Y1");
                    xyArrayRectangle[0] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine())};

                    Console.WriteLine("X2 - Y2");
                    xyArrayRectangle[1] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("X3 - Y3");
                    xyArrayRectangle[2] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("X4 - Y4");
                    xyArrayRectangle[3] = new ArrayofXY() { x = Convert.ToDouble(Console.ReadLine()), y = Convert.ToDouble(Console.ReadLine()) };

                    Console.WriteLine("(X1:Y1) - " + xyArrayRectangle[0].x.ToString() + ":" + xyArrayRectangle[0].y.ToString());
                    Console.WriteLine("(X2:Y2) - " + xyArrayRectangle[1].x.ToString() + ":" + xyArrayRectangle[1].y.ToString());
                    Console.WriteLine("(X3:Y3) - " + xyArrayRectangle[2].x.ToString() + ":" + xyArrayRectangle[2].y.ToString());
                    Console.WriteLine("(X4:Y4) - " + xyArrayRectangle[3].x.ToString() + ":" + xyArrayRectangle[3].y.ToString());

                    //Rectangle myShape = new Rectangle(xyArrayRectangle[0].x, xyArrayRectangle[0].y, xyArrayRectangle[1].x, xyArrayRectangle[1].y, xyArrayRectangle[2].x, xyArrayRectangle[2].y, xyArrayRectangle[3].x, xyArrayRectangle[3].y);
                    myShape_3 = new Rectangle(xyArrayRectangle[1] - xyArrayRectangle[0], xyArrayRectangle[2] - xyArrayRectangle[1], xyArrayRectangle[3] - xyArrayRectangle[2], xyArrayRectangle[0] - xyArrayRectangle[1]);

                    Console.WriteLine("Otkhutkhedis Perimetri = " + myShape_3.Perimeter());
                    Console.WriteLine("Otkhutkhedis Fartobia = " + myShape_3.Area());

                    Console.WriteLine();
                    continue;
                }
                else if (nFigure == 4)
                {
                    var shape = new IShape[] { myShape_1, myShape_2, myShape_3 };

                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine(shape[i].Area());
                    }
                    continue;
                }
                // Gamosvla
                else if (nFigure == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Gmadlobt Naxvamdis ;-)");

                    return;
                }

                Console.WriteLine("Shemoitane Koordinatebi...");

                Console.Write("X1: ");
                var nNumber = Convert.ToInt32(Console.ReadLine());

                Console.Write("Y1: ");

            }



        }
    }
}
