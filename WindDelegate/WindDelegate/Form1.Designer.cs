namespace WindDelegate
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
            this.lstPersonListBox = new System.Windows.Forms.ListBox();
            this.lstAutputListBox = new System.Windows.Forms.ListBox();
            this.btnProccesData = new System.Windows.Forms.Button();
            this.rdOptionDefault = new System.Windows.Forms.RadioButton();
            this.rbOptionLastName = new System.Windows.Forms.RadioButton();
            this.rbFirstName = new System.Windows.Forms.RadioButton();
            this.rbFullName = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lstPersonListBox
            // 
            this.lstPersonListBox.FormattingEnabled = true;
            this.lstPersonListBox.ItemHeight = 31;
            this.lstPersonListBox.Location = new System.Drawing.Point(55, 133);
            this.lstPersonListBox.Name = "lstPersonListBox";
            this.lstPersonListBox.Size = new System.Drawing.Size(353, 469);
            this.lstPersonListBox.TabIndex = 0;
            this.lstPersonListBox.SelectedIndexChanged += new System.EventHandler(this.lstPersonListBox_SelectedIndexChanged);
            // 
            // lstAutputListBox
            // 
            this.lstAutputListBox.FormattingEnabled = true;
            this.lstAutputListBox.ItemHeight = 31;
            this.lstAutputListBox.Location = new System.Drawing.Point(946, 133);
            this.lstAutputListBox.Name = "lstAutputListBox";
            this.lstAutputListBox.Size = new System.Drawing.Size(379, 469);
            this.lstAutputListBox.TabIndex = 1;
            // 
            // btnProccesData
            // 
            this.btnProccesData.Location = new System.Drawing.Point(461, 641);
            this.btnProccesData.Name = "btnProccesData";
            this.btnProccesData.Size = new System.Drawing.Size(440, 104);
            this.btnProccesData.TabIndex = 2;
            this.btnProccesData.Text = "Procces Data";
            this.btnProccesData.UseVisualStyleBackColor = true;
            this.btnProccesData.Click += new System.EventHandler(this.btnProccesData_Click);
            // 
            // rdOptionDefault
            // 
            this.rdOptionDefault.AutoSize = true;
            this.rdOptionDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdOptionDefault.Location = new System.Drawing.Point(558, 195);
            this.rdOptionDefault.Name = "rdOptionDefault";
            this.rdOptionDefault.Size = new System.Drawing.Size(190, 50);
            this.rdOptionDefault.TabIndex = 3;
            this.rdOptionDefault.TabStop = true;
            this.rdOptionDefault.Text = "Default";
            this.rdOptionDefault.UseVisualStyleBackColor = true;
            // 
            // rbOptionLastName
            // 
            this.rbOptionLastName.AutoSize = true;
            this.rbOptionLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionLastName.Location = new System.Drawing.Point(558, 292);
            this.rbOptionLastName.Name = "rbOptionLastName";
            this.rbOptionLastName.Size = new System.Drawing.Size(258, 50);
            this.rbOptionLastName.TabIndex = 4;
            this.rbOptionLastName.TabStop = true;
            this.rbOptionLastName.Text = "Last Name";
            this.rbOptionLastName.UseVisualStyleBackColor = true;
            // 
            // rbFirstName
            // 
            this.rbFirstName.AutoSize = true;
            this.rbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFirstName.Location = new System.Drawing.Point(558, 403);
            this.rbFirstName.Name = "rbFirstName";
            this.rbFirstName.Size = new System.Drawing.Size(261, 50);
            this.rbFirstName.TabIndex = 5;
            this.rbFirstName.TabStop = true;
            this.rbFirstName.Text = "First Name";
            this.rbFirstName.UseVisualStyleBackColor = true;
            // 
            // rbFullName
            // 
            this.rbFullName.AutoSize = true;
            this.rbFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFullName.Location = new System.Drawing.Point(555, 512);
            this.rbFullName.Name = "rbFullName";
            this.rbFullName.Size = new System.Drawing.Size(247, 50);
            this.rbFullName.TabIndex = 6;
            this.rbFullName.TabStop = true;
            this.rbFullName.Text = "Full Name";
            this.rbFullName.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 953);
            this.Controls.Add(this.rbFullName);
            this.Controls.Add(this.rbFirstName);
            this.Controls.Add(this.rbOptionLastName);
            this.Controls.Add(this.rdOptionDefault);
            this.Controls.Add(this.btnProccesData);
            this.Controls.Add(this.lstAutputListBox);
            this.Controls.Add(this.lstPersonListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPersonListBox;
        private System.Windows.Forms.ListBox lstAutputListBox;
        private System.Windows.Forms.Button btnProccesData;
        private System.Windows.Forms.RadioButton rdOptionDefault;
        private System.Windows.Forms.RadioButton rbOptionLastName;
        private System.Windows.Forms.RadioButton rbFirstName;
        private System.Windows.Forms.RadioButton rbFullName;
    }
}

