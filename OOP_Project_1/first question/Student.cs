using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1
{
    internal class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        private int test1;

        public int Test1 
        { 
            get { return test1; }
            set { if ((value < 0) || (value > 100))
                    throw new Exception("Invalid test1 score score may be more than 100 or less than 0");
            }
            
        }
        private int test2;
        public int Test2
        {
            get { return test2; }
            set
            {
                if ((value < 0) || (value > 100))
                    throw new Exception("Invalid test2 score score may be more than 100 or less than 0");
            }

        }

        public virtual string ComputeGrade()
        {
            double avg;
            string grade = "";

            avg = 0.6 * Test1 + 0.4 * Test2;
            
            if (avg > 95)
                grade = "A";
            
            else if(avg >90)
                grade = "A-";
            
            else  if(avg >85)
                grade = "B";
            
            else  if(avg >80)
                grade = "B-";
            
            else
                grade = "C";

            return grade;
        }
    }
}
