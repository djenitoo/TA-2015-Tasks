namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Teacher : Person, ICommentable, IEnumerable<Discipline>
    {
        private List<Discipline> disciplines;
        private string _comment;

        public Teacher(string name, IEnumerable<Discipline> disciplines)
            : this(name, disciplines, null) 
        {
        }
        public Teacher(string name, IEnumerable<Discipline> disciplines, string comment)
            : base(name)
        {
            this.disciplines = disciplines.ToList();
            this._comment = comment;
        }

        public List<Discipline> DisciplinesOfTeacher
        {
            get { return new List<Discipline>(this.disciplines); }
            set 
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("Disciplines of teacher cannot be blank!");
                }
                this.disciplines = value;
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
