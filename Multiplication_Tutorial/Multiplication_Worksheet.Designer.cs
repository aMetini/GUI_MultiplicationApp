namespace Multiplication_Tutorial
{
    partial class Multiplication_Worksheet
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_no1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_no2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.btn_checkAswr = new System.Windows.Forms.Button();
            this.lb_incorrect = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_correct = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_newProblem = new System.Windows.Forms.Button();
            this.tb_correctAnswer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_no1
            // 
            this.lb_no1.AutoSize = true;
            this.lb_no1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no1.Location = new System.Drawing.Point(128, 312);
            this.lb_no1.Name = "lb_no1";
            this.lb_no1.Size = new System.Drawing.Size(42, 46);
            this.lb_no1.TabIndex = 0;
            this.lb_no1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "x";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_no2
            // 
            this.lb_no2.AutoSize = true;
            this.lb_no2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no2.Location = new System.Drawing.Point(376, 312);
            this.lb_no2.Name = "lb_no2";
            this.lb_no2.Size = new System.Drawing.Size(42, 46);
            this.lb_no2.TabIndex = 2;
            this.lb_no2.Text = "0";
            this.lb_no2.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "=";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tb_answer
            // 
            this.tb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_answer.Location = new System.Drawing.Point(639, 309);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(150, 53);
            this.tb_answer.TabIndex = 4;
            // 
            // btn_checkAswr
            // 
            this.btn_checkAswr.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkAswr.Location = new System.Drawing.Point(492, 498);
            this.btn_checkAswr.Name = "btn_checkAswr";
            this.btn_checkAswr.Size = new System.Drawing.Size(183, 155);
            this.btn_checkAswr.TabIndex = 5;
            this.btn_checkAswr.Text = "Check Answer";
            this.btn_checkAswr.UseVisualStyleBackColor = true;
            this.btn_checkAswr.Click += new System.EventHandler(this.btn_checkAswr_Click_1);
            // 
            // lb_incorrect
            // 
            this.lb_incorrect.AutoSize = true;
            this.lb_incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_incorrect.Location = new System.Drawing.Point(814, 115);
            this.lb_incorrect.Name = "lb_incorrect";
            this.lb_incorrect.Size = new System.Drawing.Size(42, 46);
            this.lb_incorrect.TabIndex = 7;
            this.lb_incorrect.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "Incorrect:";
            // 
            // lb_correct
            // 
            this.lb_correct.AutoSize = true;
            this.lb_correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correct.Location = new System.Drawing.Point(814, 51);
            this.lb_correct.Name = "lb_correct";
            this.lb_correct.Size = new System.Drawing.Size(42, 46);
            this.lb_correct.TabIndex = 9;
            this.lb_correct.Text = "0";
            this.lb_correct.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(646, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 46);
            this.label8.TabIndex = 10;
            this.label8.Text = "Correct:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btn_newProblem
            // 
            this.btn_newProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newProblem.Location = new System.Drawing.Point(208, 498);
            this.btn_newProblem.Name = "btn_newProblem";
            this.btn_newProblem.Size = new System.Drawing.Size(183, 155);
            this.btn_newProblem.TabIndex = 11;
            this.btn_newProblem.Text = "New Problem";
            this.btn_newProblem.UseVisualStyleBackColor = true;
            this.btn_newProblem.Click += new System.EventHandler(this.btnNewProblem_Click);
            // 
            // tb_correctAnswer
            // 
            this.tb_correctAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_correctAnswer.Location = new System.Drawing.Point(640, 390);
            this.tb_correctAnswer.Name = "tb_correctAnswer";
            this.tb_correctAnswer.Size = new System.Drawing.Size(150, 53);
            this.tb_correctAnswer.TabIndex = 12;
            this.tb_correctAnswer.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 889);
            this.Controls.Add(this.tb_correctAnswer);
            this.Controls.Add(this.btn_newProblem);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lb_correct);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_incorrect);
            this.Controls.Add(this.btn_checkAswr);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_no2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_no1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_no1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_no2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button btn_checkAswr;
        private System.Windows.Forms.Label lb_incorrect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_correct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_newProblem;
        private System.Windows.Forms.TextBox tb_correctAnswer;
    }
}

