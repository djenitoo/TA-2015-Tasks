namespace _01.Shapes
{
    using System;

    class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {
        }
        public Square(double height, double width)
            : base (height, width)
        {
        }
        
        public override double Height
        {
            get
            {
                return base.Height;
            }
            set
            {
                if (value != base.Width)
                {
                    throw new ArgumentException("Height of square cannot be different from width!");
                }
                base.Height = value;
            }
        }

        // do not call calculate method bc square can reach it tru Rectangle
    }
}
