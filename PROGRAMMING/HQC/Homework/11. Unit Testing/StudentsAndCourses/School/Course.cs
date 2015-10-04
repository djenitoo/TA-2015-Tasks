namespace School
{
	using System;
	using System.Collections.Generic;

    public class Course
    {
	    public const int CourseCapacity = 30;
	    private readonly List<Student> _courseStudents;
	    private string _courseName;

	    public Course(string name)
	    {
		    this.CourseName = name;
		    this._courseStudents = new List<Student>();
	    }

	    public Course(string name, List<Student> joinedStudents)
			: this(name)
	    {
		    this.CourseStudents = joinedStudents;
	    }

	    public string CourseName
	    {
			get { return this._courseName; }
		    set
		    {
			    if (!string.IsNullOrEmpty(value))
			    {
				    this._courseName = value;
			    }
			    else
			    {
				    throw new ArgumentNullException(value, "Course name cannot be empty!");
			    }
		    }
	    }

		public List<Student> CourseStudents
	    {
		    get { return new List<Student>(this._courseStudents); }
			set
			{
				if (value == null || value.Count == 0)
				{
					throw new ArgumentNullException("CourseS" + "tudents", "Joining list of students cannot be null or empty!");
				}
				else
				{
					foreach (var stud in value)
					{
						CheckCourseCapacity();
						var isRepeated = this._courseStudents.Contains(stud);
						if (!isRepeated)
						{
							this._courseStudents.Add(stud);
						}
						else
						{
							throw new ArgumentException("You cannot add second time a student to the same course!");
						}
					}
				}
				
			}
	    }

	    public void AddStudent(Student student)
	    {
		    if (student != null)
		    {
				CheckCourseCapacity();
			    if (!this._courseStudents.Contains(student))
			    {
				    this._courseStudents.Add(student);
			    }
			    else
			    {
				    throw new ArgumentException("You cannot add second time a student to the same course!");
			    }
		    }
		    else
		    {
			    throw new ArgumentNullException("student" , "You cannot add empty student to a course!");
		    }
	    }
		public void RemoveStudent(Student student)
		{
			if (student != null)
			{
				if (this._courseStudents.Contains(student))
				{
					this._courseStudents.Remove(student);
				}
				else
				{
					throw new ArgumentException("Student cannot leave a unattended course!");
				}
			}
			else
			{
				throw new ArgumentNullException("student", "You cannot remove empty student from a course!");
			}
		}

	    public void CheckCourseCapacity()
	    {
		    if (this._courseStudents.Count >= CourseCapacity)
		    {
				throw new ArgumentOutOfRangeException("Course reached its capacity of " + CourseCapacity + "!");
		    }
	    }
		
    }
}
