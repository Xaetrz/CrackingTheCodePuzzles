using System;
using System.Collections.Generic;
using System.Text;

namespace CrackingTheCodePuzzles.Implementation
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
    }
    public class LineSegment
    {
        public Point StartPoint { get; set; }
        public Point EndPoint { get; set; }
        public LineSegment(Point start, Point end)
        {
            this.StartPoint = start;
            this.EndPoint = end;
        }

        public static bool DoLineSegmentsIntersect(LineSegment lineSeg1, LineSegment lineSeg2, Point lineIntersection)
        {
            return !(lineSeg1.StartPoint.X > lineIntersection.X
                      || lineSeg1.StartPoint.Y > lineIntersection.Y
                      || lineSeg1.EndPoint.X < lineIntersection.Y
                      || lineSeg1.EndPoint.Y < lineIntersection.Y
                      || lineSeg2.StartPoint.X > lineIntersection.X
                      || lineSeg2.StartPoint.Y > lineIntersection.Y
                      || lineSeg2.EndPoint.X < lineIntersection.Y
                      || lineSeg2.EndPoint.Y < lineIntersection.Y); // Note: Actually only have to check lineSeg1
        }
    }
    public class Line
    {
        public double Slope;
        public double YIntercept;
        public Line(Point start, Point end)
        {
            double deltaX = end.X - start.X;
            double deltaY = end.Y - start.Y;

            if (deltaX == 0) Slope = double.PositiveInfinity;
            else Slope = deltaX / deltaY;

            YIntercept = start.Y - Slope * start.X;
        }

        public static Boolean DoLinesIntersect(Line line1, Line line2)
        {
            if (line1.Slope == line2.Slope)
            {
                return (line1.YIntercept == line2.YIntercept);
            }
            return true;
        }

        public static Point Intersection(Line line1, Line line2)
        {
            if (!DoLinesIntersect(line1, line2)) return null;

            double xIntersect = (line2.YIntercept - line1.YIntercept) / (line1.Slope - line2.Slope);
            double yIntersect = line1.Slope * xIntersect + line1.YIntercept;
            return new Point(xIntersect, yIntersect);
        }
    }
}
