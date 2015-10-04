using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace School
{
    public class School
    {
		internal static int LastId;
	    private string _schoolName;
	    private readonly List<Course> _schoolCourses;

	    public School(string name)
	    {
		    this.Name = name;
			this._schoolCourses = new List<Course>();
		    LastId = 10000;
	    }

	    public string Name
	    {
			get { return this._schoolName; }
		    set
		    {
			    if (!string.IsNullOrEmpty(value))
			    {
				    this._schoolName = value;
			    }
			    else
			    {
				    throw new ArgumentNullException("Na" + "me", "School name cannot be null or empty!");
			    }
		    }
	    }

	    public List<Course> Courses
	    {
			get { return new List<Course>(this._schoolCourses);}
	    }

	    public void AddCourse(Course course)
	    {
		    if (course != null)
		    {
			    if (!this._schoolCourses.Contains(course))
			    {
				    this._schoolCourses.Add(course);
			    }
			    else
			    {
					throw new ArgumentException("You cannot add repeating course to a school!");
			    }
		    }
		    else
		    {
				throw new ArgumentNullException("course", "You cannot add empty course to a school!");
		    }
	    }

		public void RemoveCourse(string nameOfCourse)
		{
			if (!string.IsNullOrEmpty(nameOfCourse))
			{
				var containingTheCourse = this._schoolCourses.Where(x => x.CourseName == nameOfCourse).ToList();
				if (containingTheCourse.Count > 0)
				{
					this._schoolCourses.Remove(containingTheCourse[0]);
				}
				else
				{
					throw new ArgumentException("You cannot remove missing course!");
				}
			}
			else
			{
				throw new ArgumentNullException("Na" + "me", "Course name for removing cannot be null or empty!");
			}
		}
    }
}
