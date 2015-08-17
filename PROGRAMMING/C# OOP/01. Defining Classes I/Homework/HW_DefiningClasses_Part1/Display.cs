namespace HW_DefiningClasses_Part1
{
    using System;

    public class Display
    {
        private uint? size;
        private uint? numberOfColors;

        #region TASK 2 - CONSTRUCTORS
        public Display()
            : this(null, null)
        {

        }

        public Display(uint? size)
            : this(size, null)
        {

        }

        public Display(uint? size, uint? numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }
        
        #endregion

        #region TASK 5 - PROPERTIES
        public uint? Size
        {
            get
            {
                return this.size;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be less or equal to zero!");
                }
                this.size = value;
            }
        }

        public uint? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Size cannot be less or equal to zero!");
                }
                this.numberOfColors = value;
            }
        } 
        #endregion

        #region TASK 4 - OVERRIDE TOSTRING()
        public override string ToString()
        {
            //return base.ToString();
            return string.Format(@"
Display
Size: {0}
Colors: {1}
", this.size, this.numberOfColors);
        } 
        #endregion
    }
}
