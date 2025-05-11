namespace Ayo_Laurence_Act7_EDP
{
    partial class frmProfessorManagement
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
            this.addbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.deletebtn = new System.Windows.Forms.Button();
            this.profListView = new System.Windows.Forms.DataGridView();
            this.goBackbtn = new System.Windows.Forms.Button();
            this.refreshbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profListView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(326, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Master Professor List";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.YellowGreen;
            this.addbtn.Location = new System.Drawing.Point(284, 430);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(118, 33);
            this.addbtn.TabIndex = 1;
            this.addbtn.Text = "ADD";
            this.addbtn.UseVisualStyleBackColor = false;
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.Yellow;
            this.updatebtn.Location = new System.Drawing.Point(435, 430);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(118, 33);
            this.updatebtn.TabIndex = 2;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.UseVisualStyleBackColor = false;
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.IndianRed;
            this.deletebtn.Location = new System.Drawing.Point(593, 430);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(121, 33);
            this.deletebtn.TabIndex = 3;
            this.deletebtn.Text = "DELETE";
            this.deletebtn.UseVisualStyleBackColor = false;
            // 
            // profListView
            // 
            this.profListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.profListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profListView.Location = new System.Drawing.Point(71, 88);
            this.profListView.Name = "profListView";
            this.profListView.RowHeadersWidth = 51;
            this.profListView.RowTemplate.Height = 24;
            this.profListView.Size = new System.Drawing.Size(853, 324);
            this.profListView.TabIndex = 4;
            this.profListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.profListView_CellContentClick);
            // 
            // goBackbtn
            // 
            this.goBackbtn.Location = new System.Drawing.Point(62, 435);
            this.goBackbtn.Name = "goBackbtn";
            this.goBackbtn.Size = new System.Drawing.Size(75, 23);
            this.goBackbtn.TabIndex = 5;
            this.goBackbtn.Text = "back";
            this.goBackbtn.UseVisualStyleBackColor = true;
            this.goBackbtn.Click += new System.EventHandler(this.goBackbtn_Click);
            // 
            // refreshbtn
            // 
            this.refreshbtn.Location = new System.Drawing.Point(849, 435);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 6;
            this.refreshbtn.Text = "refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // frmProfessorManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 506);
            this.Controls.Add(this.refreshbtn);
            this.Controls.Add(this.goBackbtn);
            this.Controls.Add(this.profListView);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.label1);
            this.Name = "frmProfessorManagement";
            this.Text = "frmProfessorManagement";
            ((System.ComponentModel.ISupportInitialize)(this.profListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.DataGridView profListView;
        private System.Windows.Forms.Button goBackbtn;
        private System.Windows.Forms.Button refreshbtn;
    }
}