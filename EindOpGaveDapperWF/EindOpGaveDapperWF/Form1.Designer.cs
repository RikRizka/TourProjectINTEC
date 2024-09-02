namespace EindOpGaveDapperWF
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
            this.cmbSelecteerCMPS = new System.Windows.Forms.ComboBox();
            this.lblSelectCmps = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblFamilieNaam = new System.Windows.Forms.Label();
            this.lblWedde = new System.Windows.Forms.Label();
            this.txtVoorNaam = new System.Windows.Forms.TextBox();
            this.txtFamilieNaam = new System.Windows.Forms.TextBox();
            this.txtWedde = new System.Windows.Forms.TextBox();
            this.btnToevoengen = new System.Windows.Forms.Button();
            this.lblSelectDCNT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstSelecteerDCNT = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbSelecteerCMPS
            // 
            this.cmbSelecteerCMPS.FormattingEnabled = true;
            this.cmbSelecteerCMPS.Location = new System.Drawing.Point(99, 113);
            this.cmbSelecteerCMPS.Name = "cmbSelecteerCMPS";
            this.cmbSelecteerCMPS.Size = new System.Drawing.Size(1140, 39);
            this.cmbSelecteerCMPS.TabIndex = 0;
            // 
            // lblSelectCmps
            // 
            this.lblSelectCmps.AutoSize = true;
            this.lblSelectCmps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectCmps.Location = new System.Drawing.Point(91, 33);
            this.lblSelectCmps.Name = "lblSelectCmps";
            this.lblSelectCmps.Size = new System.Drawing.Size(449, 46);
            this.lblSelectCmps.TabIndex = 1;
            this.lblSelectCmps.Text = "Selecteer een campus:";
            this.lblSelectCmps.Click += new System.EventHandler(this.lblSelectCmps_Click);
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(93, 586);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(153, 32);
            this.lblVoornaam.TabIndex = 3;
            this.lblVoornaam.Text = "Voornaam:";
            // 
            // lblFamilieNaam
            // 
            this.lblFamilieNaam.AutoSize = true;
            this.lblFamilieNaam.Location = new System.Drawing.Point(93, 700);
            this.lblFamilieNaam.Name = "lblFamilieNaam";
            this.lblFamilieNaam.Size = new System.Drawing.Size(190, 32);
            this.lblFamilieNaam.TabIndex = 4;
            this.lblFamilieNaam.Text = "FamilieNaam:";
            // 
            // lblWedde
            // 
            this.lblWedde.AutoSize = true;
            this.lblWedde.Location = new System.Drawing.Point(93, 790);
            this.lblWedde.Name = "lblWedde";
            this.lblWedde.Size = new System.Drawing.Size(112, 32);
            this.lblWedde.TabIndex = 5;
            this.lblWedde.Text = "Wedde:";
            // 
            // txtVoorNaam
            // 
            this.txtVoorNaam.Location = new System.Drawing.Point(500, 600);
            this.txtVoorNaam.Name = "txtVoorNaam";
            this.txtVoorNaam.Size = new System.Drawing.Size(373, 38);
            this.txtVoorNaam.TabIndex = 7;
            // 
            // txtFamilieNaam
            // 
            this.txtFamilieNaam.Location = new System.Drawing.Point(500, 700);
            this.txtFamilieNaam.Name = "txtFamilieNaam";
            this.txtFamilieNaam.Size = new System.Drawing.Size(373, 38);
            this.txtFamilieNaam.TabIndex = 8;
            // 
            // txtWedde
            // 
            this.txtWedde.Location = new System.Drawing.Point(500, 801);
            this.txtWedde.Name = "txtWedde";
            this.txtWedde.Size = new System.Drawing.Size(373, 38);
            this.txtWedde.TabIndex = 9;
            // 
            // btnToevoengen
            // 
            this.btnToevoengen.Location = new System.Drawing.Point(500, 873);
            this.btnToevoengen.Name = "btnToevoengen";
            this.btnToevoengen.Size = new System.Drawing.Size(373, 56);
            this.btnToevoengen.TabIndex = 10;
            this.btnToevoengen.Text = "Toevungen";
            this.btnToevoengen.UseVisualStyleBackColor = true;
            // 
            // lblSelectDCNT
            // 
            this.lblSelectDCNT.AutoSize = true;
            this.lblSelectDCNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDCNT.Location = new System.Drawing.Point(91, 326);
            this.lblSelectDCNT.Name = "lblSelectDCNT";
            this.lblSelectDCNT.Size = new System.Drawing.Size(418, 46);
            this.lblSelectDCNT.TabIndex = 11;
            this.lblSelectDCNT.Text = "Selecteer een docent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1570, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Details een docent:";
            // 
            // lstSelecteerDCNT
            // 
            this.lstSelecteerDCNT.FormattingEnabled = true;
            this.lstSelecteerDCNT.ItemHeight = 31;
            this.lstSelecteerDCNT.Location = new System.Drawing.Point(741, 237);
            this.lstSelecteerDCNT.Name = "lstSelecteerDCNT";
            this.lstSelecteerDCNT.Size = new System.Drawing.Size(678, 283);
            this.lstSelecteerDCNT.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1572, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Voornaam:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1572, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "FamilieNaam:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1572, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Wedde:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(1012, 600);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(277, 68);
            this.btnInsert.TabIndex = 17;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1012, 700);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(277, 68);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1012, 801);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(277, 68);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(2324, 1002);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstSelecteerDCNT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectDCNT);
            this.Controls.Add(this.btnToevoengen);
            this.Controls.Add(this.txtWedde);
            this.Controls.Add(this.txtFamilieNaam);
            this.Controls.Add(this.txtVoorNaam);
            this.Controls.Add(this.lblWedde);
            this.Controls.Add(this.lblFamilieNaam);
            this.Controls.Add(this.lblVoornaam);
            this.Controls.Add(this.lblSelectCmps);
            this.Controls.Add(this.cmbSelecteerCMPS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelecteerCMPS;
        private System.Windows.Forms.Label lblSelectCmps;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblFamilieNaam;
        private System.Windows.Forms.Label lblWedde;
        private System.Windows.Forms.TextBox txtVoorNaam;
        private System.Windows.Forms.TextBox txtFamilieNaam;
        private System.Windows.Forms.TextBox txtWedde;
        private System.Windows.Forms.Button btnToevoengen;
        private System.Windows.Forms.Label lblSelectDCNT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSelecteerDCNT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

