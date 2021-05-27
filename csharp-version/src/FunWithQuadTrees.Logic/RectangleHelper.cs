﻿namespace FunWithQuadTrees.Logic
{
    public static class RectangleHelper
    {
        public static DataPoint GetNorthEast(this Rectangle rectangle)
        {
            return new DataPoint
            {
                // Get most Eastern (Xish) point
                X = rectangle.X1 > rectangle.X2 ? rectangle.X1 : rectangle.X2,

                // Get most Northern (Yish) point
                Y = rectangle.Y1 > rectangle.Y2 ? rectangle.Y1 : rectangle.Y2
            };
        }

        public static DataPoint GetSouthEast(this Rectangle rectangle)
        {
            return new DataPoint
            {
                // Get most Eastern (Xish) point
                X = rectangle.X1 > rectangle.X2 ? rectangle.X1 : rectangle.X2,

                // Get least Northern (Yish) point
                Y = rectangle.Y1 > rectangle.Y2 ? rectangle.Y2 : rectangle.Y1
            };
        }

        public static DataPoint GetSouthWest(this Rectangle rectangle)
        {
            return new DataPoint
            {
                // Get lest Eastern (Xish) point
                X = rectangle.X1 > rectangle.X2 ? rectangle.X2 : rectangle.X1,

                // Get least Northern (Yish) point
                Y = rectangle.Y1 > rectangle.Y2 ? rectangle.Y2 : rectangle.Y1
            };
        }

        public static DataPoint GetNorthWest(this Rectangle rectangle)
        {
            return new DataPoint
            {
                // Get most Eastern (Xish) point
                X = rectangle.X1 > rectangle.X2 ? rectangle.X2 : rectangle.X1,

                // Get most Northern (Yish) point
                Y = rectangle.Y1 > rectangle.Y2 ? rectangle.Y1 : rectangle.Y2
            };
        }

        public static float GetNorthBoundary(this Rectangle rectangle)
        {
            return rectangle.GetNorthEast().Y;
        }

        public static float GetEastBoundary(this Rectangle rectangle)
        {
            return rectangle.GetNorthEast().X;
        }

        public static float GetSouthBoundary(this Rectangle rectangle)
        {
            return rectangle.GetSouthWest().Y;
        }

        public static float GetWestBoundary(this Rectangle rectangle)
        {
            return rectangle.GetSouthWest().X;
        }

        public static bool ContainsPoint(this Rectangle rectangle, DataPoint dataPoint)
        {
            return 
                rectangle.GetWestBoundary() <= dataPoint.X && dataPoint.X <= rectangle.GetEastBoundary()
                &&
                rectangle.GetSouthBoundary() <= dataPoint.Y && dataPoint.Y <= rectangle.GetNorthBoundary()
                ;
        }
    }
}
