namespace HW_DefiningClasses_Part1
{
    using System;
    using System.Linq;

    public class Call
    {
        // TASK 8
        public DateTime Date{get; set;}
        public string phoneNumber;
        public uint Duration { get; set; }

        public Call(DateTime date, string number, uint duration)
        {
            this.Date = date;
            PhoneNumber = number;
            this.Duration = duration;
        }

        public string PhoneNumber
        {
            get
            {
                return this.PhoneNumber;
            }
            set
            {
                if (value.Any(x => Char.IsLetter(x)) || value[0] != '+')
                {
                    throw new ArgumentException("Phone number cannot contain letters or begin with symbol different than + !");

                }
                this.phoneNumber = value;
            }
        }

        public override string ToString()
        {
            return string.Format(this.Date + " " + this.phoneNumber + " " + this.Duration);
        }

    }
}
