using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
	[TestClass]
	public class TestSchool
	{
		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void TestEmptySchoolName()
		{
			var highSchool = new School("");
		}

		[TestMethod]
		public void TestValidSchoolName()
		{
			string validName = "Vasil Levski";
			var highSchool = new School(validName);

			Assert.AreEqual(validName, highSchool.Name, "Assigning valid name of school is not correct!");
		}

		[TestMethod]
		public void TestAddingValidCourse()
		{
			var highSchool = new School("Vasil Levski");
			var validCourse = new Course("Math");

			highSchool.AddCourse(validCourse);

			Assert.IsTrue(highSchool.Courses.Count > 0, "Unsuccesful adding of valid course to school!");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void TestAddingNullCourse()
		{
			var highSchool = new School("Vasil Levski");

			highSchool.AddCourse(null);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestAddingRepeatingCourse()
		{
			var highSchool = new School("Vasil Levski");
			var validCourse = new Course("Math");

			highSchool.AddCourse(validCourse);
			highSchool.AddCourse(validCourse);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void TestRemovingNullCourse()
		{
			var highSchool = new School("Vasil Levski");
			var validCourse = new Course("Math");

			highSchool.AddCourse(validCourse);
			highSchool.RemoveCourse("");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestRemoveMissingCourse()
		{
			var highSchool = new School("Vasil Levski");
			var validCourse = new Course("Math");
			var missingCourse = new Course("Biology");

			highSchool.AddCourse(validCourse);
			highSchool.RemoveCourse(missingCourse.CourseName);
		}

		[TestMethod]
		public void TestRemovingValidCourse()
		{
			var highSchool = new School("Vasil Levski");
			var validCourse = new Course("Math");

			highSchool.AddCourse(validCourse);
			highSchool.RemoveCourse(validCourse.CourseName);

			Assert.IsTrue(highSchool.Courses.Count == 0, "Unsuccesful valid removing of course from school!");
		}
	}
}
