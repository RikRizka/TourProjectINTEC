namespace WindAppUi
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
            this.btnCalculateAdd = new System.Windows.Forms.Button();
            this.txtFirstNr = new System.Windows.Forms.TextBox();
            this.txtSecindNr = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalculateSub = new System.Windows.Forms.Button();
            this.btnMulty = new System.Windows.Forms.Button();
            this.btnCalculateDev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalculateAdd
            // 
            this.btnCalculateAdd.Location = new System.Drawing.Point(247, 204);
            this.btnCalculateAdd.Name = "btnCalculateAdd";
            this.btnCalculateAdd.Size = new System.Drawing.Size(236, 61);
            this.btnCalculateAdd.TabIndex = 0;
            this.btnCalculateAdd.Text = "Calculate Add";
            this.btnCalculateAdd.UseVisualStyleBackColor = true;
            this.btnCalculateAdd.Click += new System.EventHandler(this.btnCalculateAdd_Click);
            // 
            // txtFirstNr
            // 
            this.txtFirstNr.Location = new System.Drawing.Point(433, 101);
            this.txtFirstNr.Name = "txtFirstNr";
            this.txtFirstNr.Size = new System.Drawing.Size(224, 38);
            this.txtFirstNr.TabIndex = 1;
            // 
            // txtSecindNr
            // 
            this.txtSecindNr.Location = new System.Drawing.Point(862, 101);
            this.txtSecindNr.Name = "txtSecindNr";
            this.txtSecindNr.Size = new System.Drawing.Size(250, 38);
            this.txtSecindNr.TabIndex = 2;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(641, 393);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(156, 54);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            // 
            // btnCalculateSub
            // 
            this.btnCalculateSub.Location = new System.Drawing.Point(631, 204);
            this.btnCalculateSub.Name = "btnCalculateSub";
            this.btnCalculateSub.Size = new System.Drawing.Size(236, 61);
            this.btnCalculateSub.TabIndex = 4;
            this.btnCalculateSub.Text = "Calculate Sub";
            this.btnCalculateSub.UseVisualStyleBackColor = true;
            // 
            // btnMulty
            // 
            this.btnMulty.Location = new System.Drawing.Point(974, 204);
            this.btnMulty.Name = "btnMulty";
            this.btnMulty.Size = new System.Drawing.Size(236, 61);
            this.btnMulty.TabIndex = 5;
            this.btnMulty.Text = "Calculate Multy";
            this.btnMulty.UseVisualStyleBackColor = true;
            // 
            // btnCalculateDev
            // 
            this.btnCalculateDev.Location = new System.Drawing.Point(1291, 214);
            this.btnCalculateDev.Name = "btnCalculateDev";
            this.btnCalculateDev.Size = new System.Drawing.Size(236, 61);
            this.btnCalculateDev.TabIndex = 6;
            this.btnCalculateDev.Text = "Calculate dev";
            this.btnCalculateDev.UseVisualStyleBackColor = true;
            this.btnCalculateDev.Click += new System.EventHandler(this.btnCalculateDev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 807);
            this.Controls.Add(this.btnCalculateDev);
            this.Controls.Add(this.btnMulty);
            this.Controls.Add(this.btnCalculateSub);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSecindNr);
            this.Controls.Add(this.txtFirstNr);
            this.Controls.Add(this.btnCalculateAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAdd;
        private System.Windows.Forms.TextBox txtFirstNr;
        private System.Windows.Forms.TextBox txtSecindNr;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalculateSub;
        private System.Windows.Forms.Button btnMulty;
        private System.Windows.Forms.Button btnCalculateDev;
    }
}

