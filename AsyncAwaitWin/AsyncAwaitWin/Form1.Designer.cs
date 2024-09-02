namespace AsyncAwaitWin
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
            this.btnProcces = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcces
            // 
            this.btnProcces.Location = new System.Drawing.Point(233, 150);
            this.btnProcces.Name = "btnProcces";
            this.btnProcces.Size = new System.Drawing.Size(502, 109);
            this.btnProcces.TabIndex = 0;
            this.btnProcces.Text = "Procces";
            this.btnProcces.UseVisualStyleBackColor = true;
            this.btnProcces.Click += new System.EventHandler(this.btnProcces_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(364, 336);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(221, 54);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Messege";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 709);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnProcces);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcces;
        private System.Windows.Forms.Label lblMessage;
    }
}

