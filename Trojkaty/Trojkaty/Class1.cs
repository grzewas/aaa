using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Trojkaty
{
    public class Point
        {
            public double X;
            public double Y;

            public Point()
            {
                X = 1;
                Y = 1;
            }

            public Point(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }

    public class Trojkat
        {
            double a;
            double b;
            double c;

            public Trojkat()
            {
                a = 3;
                b = 4;
                c = 5;
            }

            public Trojkat(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }

            public Trojkat(Point A, Point B, Point C)
            {
                a = Math.Sqrt((A.X - A.X) * (A.X - A.X) + (B.X - B.X) * (B.X - B.X));
                b = Math.Sqrt((C.X - C.X) * (C.X - C.X) + (B.X - B.X) * (B.X - B.X));
                c = Math.Sqrt((A.X - A.X) * (A.X - A.X) + (C.X - C.X) * (C.X - C.X));
            }

            public double KatA()
            {
                return (Math.Acos((c * c + b * b - a * a) / (2 * c * b)) *180/Math.PI);
            }

            public double KatB()
            {
                return (Math.Acos((a * a + c * c - b * b) / (2 * a * c)) *180/Math.PI);
            }

            public double KatC()
            {
                return (Math.Acos((a * a + b * b - c * c) / (2 * a * b)) *180/Math.PI);
            }
        
            public double ObwodTrojkata()
            {
                double obw = a + b + c;
                return obw;
            }

            public double PoleTrojkata()
            {
                double p = (a + b + c) / 2.0;
                double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                return pole;
            }
        }
    }