namespace Passaparola2
{
    partial class Result
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
            this.label1 = new System.Windows.Forms.Label();
            this.correct = new System.Windows.Forms.Label();
            this.wrong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timeLeft = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.totalPoint = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Correct: ";
            // 
            // correct
            // 
            this.correct.AutoSize = true;
            this.correct.Location = new System.Drawing.Point(258, 29);
            this.correct.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.correct.Name = "correct";
            this.correct.Size = new System.Drawing.Size(32, 32);
            this.correct.TabIndex = 1;
            this.correct.Text = "0";
            // 
            // wrong
            // 
            this.wrong.AutoSize = true;
            this.wrong.Location = new System.Drawing.Point(258, 69);
            this.wrong.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.wrong.Name = "wrong";
            this.wrong.Size = new System.Drawing.Size(32, 32);
            this.wrong.TabIndex = 3;
            this.wrong.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wrong: ";
            // 
            // timeLeft
            // 
            this.timeLeft.AutoSize = true;
            this.timeLeft.Location = new System.Drawing.Point(258, 114);
            this.timeLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.timeLeft.Name = "timeLeft";
            this.timeLeft.Size = new System.Drawing.Size(32, 32);
            this.timeLeft.TabIndex = 5;
            this.timeLeft.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Points:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Go To Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // totalPoint
            // 
            this.totalPoint.AutoSize = true;
            this.totalPoint.Location = new System.Drawing.Point(258, 152);
            this.totalPoint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.totalPoint.Name = "totalPoint";
            this.totalPoint.Size = new System.Drawing.Size(32, 32);
            this.totalPoint.TabIndex = 8;
            this.totalPoint.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Time:";
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 268);
            this.Controls.Add(this.totalPoint);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.timeLeft);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.wrong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.correct);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label correct;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timeLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label totalPoint;
        private System.Windows.Forms.Label label8;
    }
}