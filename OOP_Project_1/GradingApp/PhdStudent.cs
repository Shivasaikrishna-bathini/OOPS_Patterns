using System;
namespace GradingApp
{
	internal class PhdStudent:Student
	{
		public PhdStudent(int id, string fname, string lname, int test1, int test2, string dissertation, string advisor)
        : base(id, fname, lname, test1, test2)
        {
		}
        public string Dissertation { get; set; } = "";
        public string Advisor { get; set; } = "";

        public override string ComputeGrade()
        {
            double avg = 0.4 * Test1 + 0.6 * Test2;
            string grade = "";
            if (avg > 95)
                grade = "A";
            else if (avg > 90)
                grade = "A-";
            else if (avg > 87)
                grade = "B+";
            else if (avg > 80)
                grade = "B";
            else
                grade = "C";
            return grade;
            //throw new NotImplementedException();
        }
    }
}

