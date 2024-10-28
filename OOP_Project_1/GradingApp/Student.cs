using System;
namespace GradingApp
{
	abstract class Student
	{
		public Student(int id, string fname, string lname, int test1, int test2)
		{
			this.ID = id;
			this.FirstName = fname;
			this.LastName = lname;
			this.Test1 = test1;
			this.Test2 = test2;
		}
		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Test1 { get; set; }
		public int Test2 { get; set; }
		public abstract string ComputeGrade();
	}
}

