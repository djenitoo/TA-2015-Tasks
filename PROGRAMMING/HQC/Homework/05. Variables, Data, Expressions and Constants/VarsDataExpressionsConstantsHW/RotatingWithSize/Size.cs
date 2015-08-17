

namespace RotatingWithSize
{
    using System;

    /// <summary>
    /// Size of a figure with given width and height
    /// </summary>
    public class Size
    {
        /// <summary>
        /// Inicialize new <see cref="Size" /> with given width and height
        /// </summary>
        /// <param name="width">Width of the figure</param>
        /// <param name="height">Height of the figure of the figure</param>
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Get and set width of Size
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Get and set height of Size
        /// </summary>
        public double Height { get; set; }


        /// <summary>
        /// Calculates new size after rotating with given angle
        /// </summary>
        /// <param name="size">Given size</param>
        /// <param name="angleOfTheFigure">Angle for rotating</param>
        /// <returns>new <see cref="Size" /> instance with new parameters</returns>
        public static Size GetRotatedSize(Size size, double angleOfTheFigure)
        {
            var newWidth = Math.Abs(Math.Cos(angleOfTheFigure)) * size.width +
                           Math.Abs(Math.Sin(angleOfTheFigure)) * size.height;
            var newHeight = Math.Abs(Math.Sin(angleOfTheFigure)) * size.width +
                            Math.Abs(Math.Cos(angleOfTheFigure)) * size.height;

            return new Size(newWidth, newHeight);
        }
    }
}
