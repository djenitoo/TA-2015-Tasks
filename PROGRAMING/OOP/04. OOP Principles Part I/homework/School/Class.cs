namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Class : ICommentable
    {
        private string name;
        private string classID;
        private List<Teacher> teachers;
        private string _comment;

        public Class(string name, string ID, IEnumerable<Teacher> teachers)
            : this(name, ID, teachers, null) { }

        public Class(string name, string ID, IEnumerable<Teacher> teachers, string comment)
        {
            this.name = name;
            this.classID = ID;
            this.teachers = teachers.ToList();
            this._comment = comment;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Class ID cannot be blank!");
                }
                this.name = value;
            }
        }

        public string ClassID
        {
            get { return classID; }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Class ID cannot be blank!");
                }
                this.classID = value;
            }
        }

        public List<Teacher> Teachers
        {
            get { return new List<Teacher>(teachers); }
            set 
            {
                if (value == null || value.Count == 0)
                {
                    throw new ArgumentNullException("The set of teachers cannot be blank!");
                }
                this.teachers = value.ToList(); 
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
