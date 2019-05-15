namespace lab3
{
    partial class frmAddNewStudent
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbNewScore = new System.Windows.Forms.TextBox();
            this.tbScores = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNewScore = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAddScore = new System.Windows.Forms.Button();
            this.btClearScores = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(71, 15);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(241, 22);
            this.tbName.TabIndex = 0;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            this.tbName.Leave += new System.EventHandler(this.tbName_Leave);
            // 
            // tbNewScore
            // 
            this.tbNewScore.Location = new System.Drawing.Point(71, 48);
            this.tbNewScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNewScore.Name = "tbNewScore";
            this.tbNewScore.Size = new System.Drawing.Size(132, 22);
            this.tbNewScore.TabIndex = 1;
            // 
            // tbScores
            // 
            this.tbScores.Location = new System.Drawing.Point(71, 81);
            this.tbScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbScores.Name = "tbScores";
            this.tbScores.ReadOnly = true;
            this.tbScores.Size = new System.Drawing.Size(241, 22);
            this.tbScores.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 18);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Name:";
            // 
            // lblNewScore
            // 
            this.lblNewScore.AutoSize = true;
            this.lblNewScore.Location = new System.Drawing.Point(16, 52);
            this.lblNewScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewScore.Name = "lblNewScore";
            this.lblNewScore.Size = new System.Drawing.Size(49, 17);
            this.lblNewScore.TabIndex = 4;
            this.lblNewScore.Text = "Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(7, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Scores:";
            // 
            // btAddScore
            // 
            this.btAddScore.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAddScore.Location = new System.Drawing.Point(212, 46);
            this.btAddScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btAddScore.Name = "btAddScore";
            this.btAddScore.Size = new System.Drawing.Size(100, 28);
            this.btAddScore.TabIndex = 6;
            this.btAddScore.Text = "Add Score";
            this.btAddScore.UseVisualStyleBackColor = true;
            this.btAddScore.Click += new System.EventHandler(this.btAddScore_Click);
            // 
            // btClearScores
            // 
            this.btClearScores.Location = new System.Drawing.Point(212, 114);
            this.btClearScores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClearScores.Name = "btClearScores";
            this.btClearScores.Size = new System.Drawing.Size(100, 28);
            this.btClearScores.TabIndex = 7;
            this.btClearScores.Text = "Clear Scores";
            this.btClearScores.UseVisualStyleBackColor = true;
            this.btClearScores.Click += new System.EventHandler(this.btClearScores_Click);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(92, 162);
            this.btOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(100, 28);
            this.btOK.TabIndex = 8;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(212, 162);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(100, 28);
            this.btCancel.TabIndex = 9;
            this.btCancel.Text = "Cancel";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // frmAddNewStudent
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(324, 204);
            this.ControlBox = false;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btClearScores);
            this.Controls.Add(this.btAddScore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNewScore);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tbScores);
            this.Controls.Add(this.tbNewScore);
            this.Controls.Add(this.tbName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmAddNewStudent";
            this.Text = "Add New Student";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmAddNewStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbNewScore;
        private System.Windows.Forms.TextBox tbScores;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNewScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAddScore;
        private System.Windows.Forms.Button btClearScores;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
    }
}