namespace School
{
    using System;

    public class Student : Person, ICommentable
    {
        private int studentID;
        private string _comment;

        public Student(string name, int studentID)
            : this(name, studentID, null)
        {
        }

        public Student(string name, int studentID, string comment)
            : base(name)
        {
            this.studentID = studentID;
            this._comment = comment;
        }

        public int StudentID
        {
            get { return this.studentID; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("ID cannot be less or equal of zero!");
                }
                this.studentID = value;
            }
        }

        string ICommentable.Comment
        {
            get
            {
                return this._comment ?? "No comments to show!";
            }
            set
            {
                this._comment = value;
            }
        }
    }
}
