namespace Deffining_Classes_2.Point3D
{
    using System;
    //using Deffining_Classes_2.VersionAttr;
    // TASK 1
    public struct Point3D
    {
        private static readonly Point3D pointO = new Point3D(0,0,0);    // TASK 2
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point3D(double x, double y, double z) :this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public static Point3D PointO      // TASK 2
        {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
            return string.Format("X = {0}; Y = {1}; Z = {2};", this.X, this.Y, this.Z);
        }
    }

    // TASK 3
    public static class CalcDistance
    {
        public static double Distance(Point3D A, Point3D B)
        {
            double distance = Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2) + Math.Pow((A.Z - B.Z), 2));

            return distance;
        }
    }
}
