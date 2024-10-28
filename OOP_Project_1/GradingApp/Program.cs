// See https://aka.ms/new-console-template for more information
using System;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace GradingApp
{
    /*Console.WriteLine("Hello, World!");
    public partial class Form1 : Form
    {
        public Form1()
        {
            
        }*/
    class App
    {
        static void Main(string[] args)
        {
            //static void GradePt()
            //{
                try
            {
                string inputFile = "C:\\Users\\shivasaidynamo\\Desktop\\GradingApp\\StudentsData.txt";
                    string outputFile = "C:\\Users\\shivasaidynamo\\Desktop\\GradingApp\\grade report.txt";
                    ProcessGrades pg = new ProcessGrades();
                    pg.ReadStudentData(inputFile);
                    pg.ProcessAndWriteGrades(outputFile);
                    Console.WriteLine("Grades processed, examine file " + outputFile);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            //}
        }
    }
}

