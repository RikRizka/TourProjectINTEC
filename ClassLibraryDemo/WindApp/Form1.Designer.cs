namespace WindApp
{
    partial class Form1
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblRun = new System.Windows.Forms.Button();
            this.lblBornYear = new System.Windows.Forms.Label();
            this.txtBornYear = new System.Windows.Forms.TextBox();
            this.lstShow = new System.Windows.Forms.ListBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(201, 171);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(161, 32);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(201, 250);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(159, 32);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(391, 165);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(193, 38);
            this.txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(391, 244);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(193, 38);
            this.txtLastName.TabIndex = 3;
            // 
            // lblRun
            // 
            this.lblRun.Location = new System.Drawing.Point(391, 406);
            this.lblRun.Name = "lblRun";
            this.lblRun.Size = new System.Drawing.Size(447, 113);
            this.lblRun.TabIndex = 4;
            this.lblRun.Text = "Run";
            this.lblRun.UseVisualStyleBackColor = true;
            this.lblRun.Click += new System.EventHandler(this.lblRun_Click);
            // 
            // lblBornYear
            // 
            this.lblBornYear.AutoSize = true;
            this.lblBornYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBornYear.Location = new System.Drawing.Point(212, 330);
            this.lblBornYear.Name = "lblBornYear";
            this.lblBornYear.Size = new System.Drawing.Size(150, 32);
            this.lblBornYear.TabIndex = 16;
            this.lblBornYear.Text = "Born Year";
            // 
            // txtBornYear
            // 
            this.txtBornYear.Location = new System.Drawing.Point(391, 324);
            this.txtBornYear.Name = "txtBornYear";
            this.txtBornYear.Size = new System.Drawing.Size(193, 38);
            this.txtBornYear.TabIndex = 17;
            // 
            // lstShow
            // 
            this.lstShow.BackColor = System.Drawing.Color.Ivory;
            this.lstShow.FormattingEnabled = true;
            this.lstShow.ItemHeight = 31;
            this.lstShow.Location = new System.Drawing.Point(228, 699);
            this.lstShow.Name = "lstShow";
            this.lstShow.Size = new System.Drawing.Size(791, 159);
            this.lstShow.TabIndex = 18;
            this.lstShow.SelectedIndexChanged += new System.EventHandler(this.lstShow_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(458, 64);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 46);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "This is the best App ever";
            // 
            // txtReverse
            // 
            this.txtReverse.Location = new System.Drawing.Point(391, 566);
            this.txtReverse.Name = "txtReverse";
            this.txtReverse.Size = new System.Drawing.Size(447, 57);
            this.txtReverse.TabIndex = 20;
            this.txtReverse.Text = "Reverse";
            this.txtReverse.UseVisualStyleBackColor = true;
            this.txtReverse.Click += new System.EventHandler(this.txtReverse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1405, 1004);
            this.Controls.Add(this.txtReverse);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lstShow);
            this.Controls.Add(this.txtBornYear);
            this.Controls.Add(this.lblBornYear);
            this.Controls.Add(this.lblRun);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button lblRun;
        private System.Windows.Forms.Label lblBornYear;
        private System.Windows.Forms.TextBox txtBornYear;
        private System.Windows.Forms.ListBox lstShow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button txtReverse;
    }
}

