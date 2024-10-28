using System;
namespace GradingApp
{
	internal interface IProcessGrades
	{
		void ReadStudentData(string inputFileName);
		void ProcessAndWriteGrades(string outFileName);
    }
}

