namespace FormattingHW
{
    using System;
    using System.Text;

    public class Event : IComparable
    {
        private DateTime date;
        private string title, location;

        public Event(DateTime date, string title, string location)
        {
            this.date = date;
            this.title = title;
            this.location = location;
        }

        public int CompareTo(object obj)
        {
            var other = obj as Event;
            var byDate = this.date.CompareTo(other.date);
            var byTitle = this.title.CompareTo(other.title);
            var byLocation = this.location.CompareTo(other.location);

            if (byDate == 0)
            {
                return byTitle == 0 ? byLocation : byTitle;
            }

            return byDate;
        }

        public override string ToString()
        {
            var toString = new StringBuilder();

            toString.Append(this.date.ToString("yyyy-MM-ddTHH:mm:ss"));
            toString.Append(" | " + this.title);

            if (!string.IsNullOrEmpty(this.location))
            {
                toString.Append(" | " + this.location);
            }

            return toString.ToString();
        }
    }
}
