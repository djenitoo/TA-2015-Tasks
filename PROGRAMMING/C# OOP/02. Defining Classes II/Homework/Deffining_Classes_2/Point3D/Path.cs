namespace Deffining_Classes_2.Point3D
{
    using System;
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> sequenceOfPoints;

        public List<Point3D> SequenceOfPoints
        {
            get
            {
                return this.sequenceOfPoints;
            }
        }

        public Path()
        {
            sequenceOfPoints = new List<Point3D>();
        }

        public void AddPoint(Point3D A)
        {
            this.sequenceOfPoints.Add(A);
        }

        public void DeletePoint(int index)
        {
            if (index < 0 || index >= this.sequenceOfPoints.Count)
            {
                throw new IndexOutOfRangeException("There is no point to remove at the given index!");
            }
            this.sequenceOfPoints.RemoveAt(index);
        }

        public override string ToString()
        {
            string output = String.Empty;

            foreach (Point3D item in this.sequenceOfPoints)
            {
                output += item.X + " " + item.Y + " " + item.Z + ";";
            }
            return output;
        }
    }
}
