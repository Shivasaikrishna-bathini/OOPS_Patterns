﻿using System;
namespace GradingApp
{
	internal class UnderGradStudent:Student
	{
		public UnderGradStudent(int id, string fname, string lname, int test1, int test2)
            :base(id,fname,lname,test1,test2)
		{

		}

        public override string ComputeGrade()
        {
            double avg = 0.4 * Test1 + 0.6 * Test2;
            string grade = "";
            if (avg > 90)
                grade = "A";
            else if (avg > 85)
                grade = "A-";
            else if (avg > 80)
                grade = "B+";
            else if (avg > 70)
                grade = "B";
            else
                grade = "C";
            return grade;
            //throw new NotImplementedException();
        }
    }
}

