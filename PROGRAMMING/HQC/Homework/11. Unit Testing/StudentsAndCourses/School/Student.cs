namespace School
{
	using System;

	public class Student
	{
		private string _name;

		public Student(string name)
		{
			this.Name = name;
			this.Id = School.LastId++;
		}

		public string Name
		{
			get { return this._name; }
			set
			{
				if (!string.IsNullOrEmpty(value))
				{
					this._name = value;
				}
				else
				{
					throw new ArgumentNullException(value, "Student name should not be empty!");
				}
			}
		}

		public int Id { get; private set; }
	}
}
