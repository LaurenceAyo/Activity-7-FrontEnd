namespace Ayo_Laurence_Act7_EDP
{
    partial class AnswerMePrompt
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
            this.label2 = new System.Windows.Forms.Label();
            this.answerToQuestion = new System.Windows.Forms.TextBox();
            this.submitAnswerBtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Answer a Security Question";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(471, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Who\'s the first President of the Philippines?";
            // 
            // answerToQuestion
            // 
            this.answerToQuestion.Location = new System.Drawing.Point(60, 205);
            this.answerToQuestion.Name = "answerToQuestion";
            this.answerToQuestion.Size = new System.Drawing.Size(341, 22);
            this.answerToQuestion.TabIndex = 2;
            this.answerToQuestion.Text = "Name";
            this.answerToQuestion.TextChanged += new System.EventHandler(this.answerToQuestion_TextChanged);
            // 
            // submitAnswerBtn
            // 
            this.submitAnswerBtn.BackColor = System.Drawing.Color.YellowGreen;
            this.submitAnswerBtn.Location = new System.Drawing.Point(397, 313);
            this.submitAnswerBtn.Name = "submitAnswerBtn";
            this.submitAnswerBtn.Size = new System.Drawing.Size(167, 54);
            this.submitAnswerBtn.TabIndex = 3;
            this.submitAnswerBtn.Text = "Submit Answer";
            this.submitAnswerBtn.UseVisualStyleBackColor = false;
            this.submitAnswerBtn.Click += new System.EventHandler(this.submitAnswerBtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(201, 313);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(167, 54);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // AnswerMePrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.submitAnswerBtn);
            this.Controls.Add(this.answerToQuestion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AnswerMePrompt";
            this.Text = "Security Question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answerToQuestion;
        private System.Windows.Forms.Button submitAnswerBtn;
        private System.Windows.Forms.Button backbtn;
    }
}