using System;
namespace GradingApp
{
	internal class ProcessGrades:IProcessGrades
	{
        public List<Student> STList { get; set; } = new List<Student>();

        public void ProcessAndWriteGrades(string outFileName)
        {
            StreamWriter sw = new StreamWriter(outFileName);
            try
            {
                foreach (Student st in STList)
                {
                    string grade = st.ComputeGrade();
                    sw.WriteLine(st.ID + "\t" + grade);
                }
            }
            catch
            {
                throw;// new NotImplementedException();
            }
            finally
            {
                sw.Close();
            }
        }

        public void ReadStudentData(string inputFileName)
        {
            try
            {
                STList.Clear();
                StreamReader sr = new StreamReader(inputFileName);
                string? sline = sr.ReadLine();
                while (sline != null)
                {
                    Student? st = null;
                    string[] parts = sline.Split(new char[] { '\t' });
                    if (parts.Length == 6)
                    {
                        if (parts[3].ToUpper() == "UNDERGRAD")
                        {
                            st = new UnderGradStudent(int.Parse(parts[0]), parts[1], parts[2],
                                                      int.Parse(parts[4]), int.Parse(parts[5]));
                        }
                    }
                    if (parts.Length == 7)
                    {
                        if (parts[3].ToUpper() == "GRADUATE")
                        {
                            st = new GradStudent(int.Parse(parts[0]), parts[1], parts[2],
                                                 int.Parse(parts[4]), int.Parse(parts[5]), parts[6]);
                        }
                    }
                    if (parts.Length == 8)
                    {
                        if (parts[3].ToUpper() == "PHDCPSC")
                        {
                            st = new PhdStudent(int.Parse(parts[0]), parts[1], parts[2],
                                                int.Parse(parts[4]), int.Parse(parts[5]), parts[6], parts[7]);

                        }
                    }
                    if (st != null)
                        STList.Add(st);
                    sline = sr.ReadLine();
                }
            }
            catch
            {
                throw;// new NotImplementedException();
            }
        }
    }
}

