using System.Linq.Expressions;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student student1 = new Student();
                student1.Id = 1211303;
                student1.FirstName = "ShivaSai";
                student1.LastName = "Krishna";
                student1.Test1 = 90;
                student1.Test2 = 180;
                string grade = student1.ComputeGrade();
                MessageBox.Show(grade);
                MessageBox.Show(student1.FirstName);
                System.Windows.Forms.MessageBox.Show(student1.Id.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Graduatestudent gs1 = new Graduatestudent();
            gs1.FirstName = "chetan";
            gs1.LastName = "chhetri";
            gs1.Test1 = 85;
            gs1.Test2 = 92;
            gs1.Thesis = "computer science";
            string grade = gs1.ComputeGrade();
            MessageBox.Show(grade);
            MessageBox.Show(gs1.FirstName);
            MessageBox.Show(gs1.greet());
            MessageBox.Show(gs1.Thesis);

        }
    }
}