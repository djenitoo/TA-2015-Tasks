using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
	[TestClass]
	public class TestStudent
	{
		[TestMethod]
		public void TestStudentWithCorrectName()
		{
			School highSchool = new School("Vasil Levski");
			string correctName = "Peter";
			var correctStudent = new Student(correctName);

			Assert.AreEqual("Peter", correctStudent.Name, "Student names are not equal!");

		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void TestEmptyStudentName()
		{
			School highSchool = new School("Vasil Levski");
			string incorrectName = "";
			var incorrectStudent = new Student(incorrectName);
		}

		[TestMethod]
		public void TestIfStudentIdIsNotRepeating()
		{
			School highSchool = new School("Vasil Levski");
			var correctStudent = new Student("Peter");
			var secondStudent = new Student("Maria");

			Assert.AreNotEqual(correctStudent.Id, secondStudent.Id, "Student id's sould not be equal!");

		}
	}
}
