using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Division_Tutorial
{
    public partial class Divison_Worksheet : Form
    {
        int correct = 0;
        int incorrect = 0;
        public Divison_Worksheet()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_newProblem_Click(object sender, EventArgs e)
        {
            int no1, no2;
            Random rand = new Random();
            no1 = rand.Next(12) + 1;
            no2 = rand.Next(12) + 1;

            lb_no1.Text = no1.ToString();
            lb_no2.Text = no2.ToString();
        }

        private void btn_checkAnswer_Click(object sender, EventArgs e)
        {
            int no1, no2;
            float answer;
            no1 = int.Parse(lb_no1.Text);
            no2 = int.Parse(lb_no2.Text);
            answer = int.Parse(tb_answer.Text);

            if ((float)(no1 / no2) == answer)
            {
                correct++;
            }
            else
            {
                incorrect++;
            }
            lb_correct.Text = correct.ToString();
            lb_incorrect.Text = incorrect.ToString();
        }
    }
}
