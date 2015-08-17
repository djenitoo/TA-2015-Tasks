namespace School
{
    using System;

    public class Discipline : ICommentable
    {
        private string name;
        private string _comment;
        private int numberOfLectures;
        private int numberOfExercises;

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
            : this(name, numberOfLectures, numberOfExercises, null)
        {
        }

        public Discipline(string name, int numberOfLectures, int numberOfExercises, string comment)
        {
            this.name = name;
            this.numberOfLectures = numberOfLectures;
            this.numberOfExercises = numberOfExercises;
            this._comment = comment ?? "No comments.";
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public string Comment
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

        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 0)  // there can be disciplines only with exercises like fizichesko, etc.
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be less than zero!");
                }
                this.numberOfLectures = value;
            }
        }

        public int NumberOfExercises
        {
            get
            {
                return this.numberOfExercises;
            }
            set
            {
                if (value < 0)  // there can be disciplines only with exercises like fizichesko, etc.
                {
                    throw new ArgumentOutOfRangeException("Number of lectures cannot be less than zero!");
                }
                this.numberOfExercises = value;
            }
        }

    }
}
