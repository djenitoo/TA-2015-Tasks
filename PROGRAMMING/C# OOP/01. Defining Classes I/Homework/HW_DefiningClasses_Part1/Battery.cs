namespace HW_DefiningClasses_Part1
{
    using System;

    public class Battery
    {
        private string batteryModel;
        private int? idleHours;
        private int? talkHours;
        private BatteryType typeOfBattery;

        #region TASK 2 - CONSTRUCTORS
        public Battery()
            : this(null, null, null)
        {

        }

        public Battery(string batteryModel)
            : this(batteryModel, null, null)
        {

        }

        public Battery(string batteryModel, int? idleHours)
            : this(batteryModel, idleHours, null)
        {

        }

        public Battery(string batteryModel, int? idleHours, int? talkHours)
            : this(batteryModel, idleHours, talkHours, new BatteryType())
        {

        }

        public Battery(string batteryModel, int? idleHours, int? talkHours, BatteryType typeOfBattery)
        {
            this.batteryModel = batteryModel;
            this.idleHours = idleHours;
            this.talkHours = talkHours;
            this.typeOfBattery = typeOfBattery;
        } 
        #endregion

        #region TASK 5 - PROPERTIES
        public string BatteryModel
        {
            get
            {
                return this.batteryModel;
            }
            private set
            {
                this.batteryModel = value;
            }
        }

        public int? IdleHours
        {
            get
            {
                return this.idleHours;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Idle hours cant be less than 0!");
                }

                this.idleHours = value;
            }
        }

        public int? TalkHours
        {
            get
            {
                return this.talkHours;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Talk hours can't be less than 0!");
                }

                this.talkHours = value;
            }
        }

        public BatteryType TypeOfBattery
        {
            get
            {
                return this.typeOfBattery;
            }
            set
            {
                if (!(Enum.IsDefined(typeof(BatteryType), value)))
                {
                    throw new ArgumentException("Invalid Argument!");
                }
                this.TypeOfBattery = value;
            }
        } 
        #endregion

        #region TASK 4 - OVERRIDE TOSTRING()
        public override string ToString()
        {
            //return base.ToString();
            return string.Format(@"
Battery
Model: {0}
Type: {1}
Idle hours: {2}
Hours to talk: {3}
", this.batteryModel ?? " ", this.typeOfBattery, this.idleHours, this.talkHours);
        } 
        #endregion
    }
}
