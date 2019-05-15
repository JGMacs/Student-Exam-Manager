namespace lab3
{
    partial class frmStudentScores
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.lblStudents = new System.Windows.Forms.Label();
            this.btAddnew = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.lblScoretotal = new System.Windows.Forms.Label();
            this.lblScorecount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.ItemHeight = 16;
            this.lbStudents.Location = new System.Drawing.Point(17, 47);
            this.lbStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(284, 132);
            this.lbStudents.TabIndex = 1;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Location = new System.Drawing.Point(17, 16);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(68, 17);
            this.lblStudents.TabIndex = 99;
            this.lblStudents.Text = "Students:";
            // 
            // btAddnew
            // 
            this.btAddnew.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btAddnew.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAddnew.Location = new System.Drawing.Point(311, 47);
            this.btAddnew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddnew.Name = "btAddnew";
            this.btAddnew.Size = new System.Drawing.Size(100, 28);
            this.btAddnew.TabIndex = 0;
            this.btAddnew.Text = "Add New...";
            this.btAddnew.UseVisualStyleBackColor = true;
            this.btAddnew.Click += new System.EventHandler(this.btAddnew_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btUpdate.Location = new System.Drawing.Point(311, 82);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(100, 28);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Update...";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDelete.Location = new System.Drawing.Point(311, 118);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(100, 28);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbTotal.Location = new System.Drawing.Point(240, 194);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(61, 22);
            this.tbTotal.TabIndex = 99;
            this.tbTotal.TabStop = false;
            // 
            // tbCount
            // 
            this.tbCount.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbCount.Location = new System.Drawing.Point(240, 228);
            this.tbCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCount.Name = "tbCount";
            this.tbCount.ReadOnly = true;
            this.tbCount.Size = new System.Drawing.Size(61, 22);
            this.tbCount.TabIndex = 99;
            this.tbCount.TabStop = false;
            // 
            // tbAverage
            // 
            this.tbAverage.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.tbAverage.Location = new System.Drawing.Point(240, 261);
            this.tbAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(61, 22);
            this.tbAverage.TabIndex = 99;
            this.tbAverage.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btExit.Location = new System.Drawing.Point(311, 258);
            this.btExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 28);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lblScoretotal
            // 
            this.lblScoretotal.AutoSize = true;
            this.lblScoretotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScoretotal.Location = new System.Drawing.Point(151, 194);
            this.lblScoretotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScoretotal.Name = "lblScoretotal";
            this.lblScoretotal.Size = new System.Drawing.Size(82, 19);
            this.lblScoretotal.TabIndex = 0;
            this.lblScoretotal.Text = "Score total:";
            this.lblScoretotal.Click += new System.EventHandler(this.lblScoretotal_Click);
            // 
            // lblScorecount
            // 
            this.lblScorecount.AutoSize = true;
            this.lblScorecount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblScorecount.Location = new System.Drawing.Point(141, 228);
            this.lblScorecount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScorecount.Name = "lblScorecount";
            this.lblScorecount.Size = new System.Drawing.Size(90, 19);
            this.lblScorecount.TabIndex = 0;
            this.lblScorecount.Text = "Score count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAverage.Location = new System.Drawing.Point(165, 261);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(67, 19);
            this.lblAverage.TabIndex = 0;
            this.lblAverage.Text = "Average:";
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btExit;
            this.ClientSize = new System.Drawing.Size(427, 300);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScorecount);
            this.Controls.Add(this.lblScoretotal);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAddnew);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.lbStudents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmStudentScores";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            this.VisibleChanged += new System.EventHandler(this.frmStudentScores_Enter);
            this.Enter += new System.EventHandler(this.frmStudentScores_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btAddnew;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lblScoretotal;
        private System.Windows.Forms.Label lblScorecount;
        private System.Windows.Forms.Label lblAverage;
    }
}

