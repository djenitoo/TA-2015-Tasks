using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace School.Test
{
	[TestClass]
	public class TestCourse
	{
		[TestMethod]
		public void TestCorrectCourseName()
		{
			string correctName = "Mathematica";
			var mathematicaCourse = new Course(correctName);

			Assert.AreEqual(correctName, mathematicaCourse.CourseName, "Correct course name assigment throws error!");

		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentNullException))]
		public void TestEmptyCourseName()
		{
			var mathematicaCourse = new Course("");
		}

		[TestMethod]
		public void TestCorrectCourseWithStudentsList()
		{
			var highSchool = new School("Vasil Levski");
			var studentList = new List<Student>
			{
				new Student("Georgi"),
				new Student("Peter2")
			};

			var courseMath = new Course("Math", studentList);

			CollectionAssert.AreEqual((new Course("Math", studentList)).CourseStudents, courseMath.CourseStudents,
				"Added students are not in equal lists!");
		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentNullException))]
		public void TestEmptyJoinedStudents()
		{
			var highSchool = new School("Vasil Levski");
			var joiningStudents = new List<Student>();

			var inaccurateCourse = new Course("Math", joiningStudents);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestRepeatingJoinedStudents()
		{
			var highSchool = new School("Vasil Levski");
			var repeatingStudent = new Student("Ivaylo");
			var studentList = new List<Student>
			{
				new Student("Niki"),
				repeatingStudent,
				new Student("Doncho"),
				repeatingStudent
			};

			var inaccurateCourse = new Course("Math", studentList);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void TestCapacityOverloadOfCourse()
		{
			var highSchool = new School("Vasil Levski");
			var mathCourse = new Course("Math");
			for (int i = 0; i <= Course.CourseCapacity; i++)
			{
				mathCourse.AddStudent(new Student("Misha" + i));
			}
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void AddNullStudentToCourse()
		{
			var highSchool = new School("Vasil Levski");
			var studentList = new List<Student>
			{
				new Student("Niki"),
				new Student("Doncho")
			};

			var inaccurateCourse = new Course("Math", studentList);
			inaccurateCourse.AddStudent(null);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void AddRepeatingStudentToCourse()
		{
			var highSchool = new School("Vasil Levski");
			var repeatingStudent = new Student("Ivaylo");
			var studentList = new List<Student>
			{
				new Student("Niki"),
				new Student("Doncho"),
				repeatingStudent
			};

			var inaccurateCourse = new Course("Math", studentList);
			inaccurateCourse.AddStudent(repeatingStudent);
		}

		[TestMethod]
		public void AddCorrectStudentToCourse()
		{
			var highSchool = new School("Vasil Levski");
			var ivayloStudent = new Student("Ivaylo");
			var studentList = new List<Student>
			{
				new Student("Niki"),
				new Student("Doncho")
			};

			var accurateCourse = new Course("Math", studentList);
			accurateCourse.AddStudent(ivayloStudent);

			var expectedList = new List<Student>();
			expectedList = studentList;
			expectedList.Add(ivayloStudent);
			CollectionAssert.AreEqual(expectedList, accurateCourse.CourseStudents,
				"Student list of the course is not correct with the expected!");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void TestRemovingNullStudentOfCourse()
		{
			var highSchool = new School("Vasil Levski");
			var studentList = new List<Student>
			{
				new Student("Niki"),
				new Student("Doncho")
			};

			var mathCourse = new Course("Math", studentList);
			mathCourse.RemoveStudent(null);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void TestRemovingNotAttendingStudentFromCourse()
		{
			var highSchool = new School("Vasil Levski");
			var notJoinedStudent = new Student("Ivaylo");
			var studentList = new List<Student>
			{
				new Student("Niki"),
				new Student("Doncho")
			};

			var mathCourse = new Course("Math", studentList);
			mathCourse.RemoveStudent(notJoinedStudent);
		}

		[TestMethod]
		public void TestRemovingAttendingStudentFromCourse()
		{
			var highSchool = new School("Vasil Levski");
			var joinedStudent = new Student("Ivaylo");
			var studentList = new List<Student>
			{
				new Student("Niki"),
				new Student("Doncho"),
				joinedStudent
			};

			var mathCourse = new Course("Math", studentList);
			mathCourse.RemoveStudent(joinedStudent);

			bool isRemoved = !(mathCourse.CourseStudents).Contains(joinedStudent);

			Assert.IsTrue(isRemoved, "The removed student is still in the course list!");
		}
	}
}
