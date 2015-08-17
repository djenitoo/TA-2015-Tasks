namespace HW_DefiningClasses_Part1
{
    using System;
    using System.Collections.Generic;
    
    public class GSM
    {   
        // TASK 1
        private string model;               
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory;
        
        //TASK 6
        private static readonly GSM iPhone4S = new GSM("IPhone4S", "Apple", 1400M, "John Doe", new Battery("456Bat4S", 15, 6, BatteryType.LiIon), new Display(4, 16000000));

        #region TASK 2 - CONSTRUCTORS
        public GSM(string model, string manufacturer)
            : this(model, manufacturer, null)
        {

        }

        public GSM(string model, string manufacturer, decimal? price)
            : this(model, manufacturer, price, null)
        {

        }

        public GSM(string model, string manufacturer, decimal? price, string owner)
            : this(model, manufacturer, price, owner, null)
        {

        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery)
            : this(model, manufacturer, price, owner, battery, null)
        {

        }

        public GSM(string model, string manufacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.battery = battery ?? new Battery();
            this.display = display ?? new Display();
        }
        
        #endregion

        #region TASK 5 - PROPERTIES
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value; // decided to leave it without cheking for len. or numbers, bc is possible to company name to be only number/letter
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0) //left it to be 0, bc then is free?
                {
                    throw new ArgumentOutOfRangeException("Price cannot be less than zero!");
                }
                this.price = value;
            }
        }

        public Battery BatteryOfGSM
        {
            get
            {
                return this.battery;
            }
            set
            {
                if (!(value is Battery) || (value == null))
                {
                    throw new ArgumentException("Wrong type for battery!");
                }
                this.battery = value;
            }
        }

        public Display DisplayOfGSM
        {
            get
            {
                return this.display;
            }
            set
            {
                if ((value is Display) || (value == null))
                {
                    throw new ArgumentException("Display type is not correct!");
                }
                this.display = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Owner name should be more than 1 letter!");
                }
                this.owner = value;
            }
        } 
        #endregion

        // TASK 9
        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
            set
            {
                if (!(value is List<Call>))
                {
                    throw new ArgumentException("The value should be of List<Cal> type!");
                }
                this.callHistory = value;
            }
        }


        #region TASK 4 - OVERRIDE TOSTRING()
        public override string ToString()
        {
            //return base.ToString();
            //string output = 
            return string.Format(@"GSM
Model: {0}
Manufacturer: {1}
Price: {2}
Owner: {3}
{4}
{5}", this.model, this.manufacturer, this.price, this.owner, this.battery.ToString(), this.display.ToString()); ;
        } 
        #endregion

        #region TASK 6 - IPHONE
        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
        } 
        #endregion

        #region TASK 10 - ADD&DEL CALL
        public void AddCall(Call val)
        {
            if (this.callHistory == null)
            {
                this.callHistory = new List<Call>();
            }
            if (!(val is Call))
            {
                throw new ArgumentException("Incorrect type of Call!");
            }

            this.callHistory.Add(val);
        }


        public void DeleteCall(int index)
        {
            if (index >= 0 && index < this.callHistory.Count)
            {
                this.callHistory.RemoveAt(index);
            }
            else
            {
                throw new IndexOutOfRangeException("The call index was out of the bounds of the array!");
            }
        } 
        #endregion

        // TASK 12
        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        // TASK 11
        public decimal TotalCallPrice(decimal pricePerMinute)
        {
            uint totalSeconds = 0;

            foreach (Call conversation in this.callHistory)
            {
                totalSeconds += conversation.Duration;
            }

            return ((totalSeconds / 60) + 1) * pricePerMinute;
        }
    }
}
