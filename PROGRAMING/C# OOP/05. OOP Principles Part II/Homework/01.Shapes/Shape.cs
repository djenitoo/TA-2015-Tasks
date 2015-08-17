namespace _01.Shapes
{
    using System;

    public abstract class Shape
    {
        private double height;
        private double width;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width cannot be less of equal of zero!");
                }
                this.width = value;
            }
        }
        public virtual double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height cannot be less of equal of zero!");
                }
                this.height = value;
            }
        }

        public virtual double CalculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
