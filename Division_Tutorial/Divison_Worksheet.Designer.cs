namespace Division_Tutorial
{
    partial class Divison_Worksheet
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
            this.lb_no2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_num2 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_newProblem = new System.Windows.Forms.Button();
            this.btn_checkAnswer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_correct = new System.Windows.Forms.Label();
            this.lb_incorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_no1
            // 
            this.lb_no1.AutoSize = true;
            this.lb_no1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no1.Location = new System.Drawing.Point(202, 349);
            this.lb_no1.Name = "lb_no1";
            this.lb_no1.Size = new System.Drawing.Size(42, 46);
            this.lb_no1.TabIndex = 0;
            this.lb_no1.Text = "0";
            // 
            // lb_no2
            // 
            this.lb_no2.AutoSize = true;
            this.lb_no2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_no2.Location = new System.Drawing.Point(403, 342);
            this.lb_no2.Name = "lb_no2";
            this.lb_no2.Size = new System.Drawing.Size(42, 46);
            this.lb_no2.TabIndex = 1;
            this.lb_no2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "/";
            // 
            // lb_num2
            // 
            this.lb_num2.AutoSize = true;
            this.lb_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_num2.Location = new System.Drawing.Point(383, 345);
            this.lb_num2.Name = "lb_num2";
            this.lb_num2.Size = new System.Drawing.Size(0, 46);
            this.lb_num2.TabIndex = 3;
            // 
            // tb_answer
            // 
            this.tb_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_answer.Location = new System.Drawing.Point(586, 342);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(150, 53);
            this.tb_answer.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(499, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 46);
            this.label5.TabIndex = 5;
            this.label5.Text = "=";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 46);
            this.label6.TabIndex = 6;
            this.label6.Text = "Correct: ";
            // 
            // btn_newProblem
            // 
            this.btn_newProblem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newProblem.Location = new System.Drawing.Point(184, 545);
            this.btn_newProblem.Name = "btn_newProblem";
            this.btn_newProblem.Size = new System.Drawing.Size(178, 150);
            this.btn_newProblem.TabIndex = 7;
            this.btn_newProblem.Text = "New Division Problem";
            this.btn_newProblem.UseVisualStyleBackColor = true;
            this.btn_newProblem.Click += new System.EventHandler(this.btn_newProblem_Click);
            // 
            // btn_checkAnswer
            // 
            this.btn_checkAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkAnswer.Location = new System.Drawing.Point(546, 545);
            this.btn_checkAnswer.Name = "btn_checkAnswer";
            this.btn_checkAnswer.Size = new System.Drawing.Size(190, 150);
            this.btn_checkAnswer.TabIndex = 8;
            this.btn_checkAnswer.Text = "Check Answer";
            this.btn_checkAnswer.UseVisualStyleBackColor = true;
            this.btn_checkAnswer.Click += new System.EventHandler(this.btn_checkAnswer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "Incorrect: ";
            // 
            // lb_correct
            // 
            this.lb_correct.AutoSize = true;
            this.lb_correct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_correct.Location = new System.Drawing.Point(759, 23);
            this.lb_correct.Name = "lb_correct";
            this.lb_correct.Size = new System.Drawing.Size(42, 46);
            this.lb_correct.TabIndex = 10;
            this.lb_correct.Text = "0";
            // 
            // lb_incorrect
            // 
            this.lb_incorrect.AutoSize = true;
            this.lb_incorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_incorrect.Location = new System.Drawing.Point(759, 90);
            this.lb_incorrect.Name = "lb_incorrect";
            this.lb_incorrect.Size = new System.Drawing.Size(42, 46);
            this.lb_incorrect.TabIndex = 11;
            this.lb_incorrect.Text = "0";
            // 
            // Divison_Worksheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 660);
            this.Controls.Add(this.lb_incorrect);
            this.Controls.Add(this.lb_correct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_checkAnswer);
            this.Controls.Add(this.btn_newProblem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.lb_num2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_no2);
            this.Controls.Add(this.lb_no1);
            this.Name = "Divison_Worksheet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_no1;
        private System.Windows.Forms.Label lb_no2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_num2;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_newProblem;
        private System.Windows.Forms.Button btn_checkAnswer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_correct;
        private System.Windows.Forms.Label lb_incorrect;
    }
}

