using DocumentFormat.OpenXml.Vml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_Tutorial
{
    public partial class Multiplication_Worksheet : Form
    {
        int correct = 0;
        int incorrect = 0;
        public Multiplication_Worksheet()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnNewProblem_Click(object sender, EventArgs e)
        {
            int num1, num2;
            Random random = new Random();
            num1 = random.Next(12) + 1;
            num2 = random.Next(12) + 1;

            lb_no1.Text = num1.ToString();
            lb_no2.Text = num2.ToString();

        }

        private void btn_checkAswr_Click_1(object sender, EventArgs e)
        {
            int num1, num2, answer, answer2;
            num1 = int.Parse(lb_no1.Text);
            num2 = int.Parse(lb_no2.Text);
            answer = int.Parse(tb_answer.Text);
            answer2 = int.Parse(tb_correctAnswer.Text);
            answer2 = num1 * num2;

            if ((num1 * num2) == answer)
            {
                correct++;
            }
            else
            {
                incorrect++;
                //answer2 = (num1 * num2);
                
                tb_correctAnswer.Visible = true;
                tb_correctAnswer.Text = answer.ToString();
            }
            lb_correct.Text = correct.ToString();
            lb_incorrect.Text = incorrect.ToString();
        }
    }
}
