using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Graduatestudent: Student
    {
        public string Thesis { get; set; } = "";

        public string greet()
        {
            return "this is graduate student you have selected";
        }
        public override string ComputeGrade()
        {
            double avg;
            string grade = "";
            avg = 0.5 * Test1 + 0.5 * Test2;

            if (avg > 95)
                grade = "A";
           
            else if (avg > 90)
                grade = "A-";
            
            else if (avg > 85)
                grade = "B";
           
            else if (avg > 80)
                grade = "B-";
           
            else
                grade = "C";

            return grade;
        }
    }
}
