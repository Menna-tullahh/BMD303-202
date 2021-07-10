
namespace physical_therapy_system
{
    partial class Patients
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
            this.listPatient1 = new physical_therapy_system.ListPatient();
            this.listPatient2 = new physical_therapy_system.ListPatient();
            this.listPatient3 = new physical_therapy_system.ListPatient();
            this.listPatient4 = new physical_therapy_system.ListPatient();
            this.SuspendLayout();
            // 
            // listPatient1
            // 
            this.listPatient1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.listPatient1.Location = new System.Drawing.Point(150, 71);
            this.listPatient1.Name = "listPatient1";
            this.listPatient1.Size = new System.Drawing.Size(2044, 211);
            this.listPatient1.TabIndex = 0;
            this.listPatient1.Load += new System.EventHandler(this.listPatient1_Load);
            this.listPatient1.Click += new System.EventHandler(this.listPatient4_Click);
            // 
            // listPatient2
            // 
            this.listPatient2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.listPatient2.Location = new System.Drawing.Point(150, 307);
            this.listPatient2.Name = "listPatient2";
            this.listPatient2.Size = new System.Drawing.Size(2044, 211);
            this.listPatient2.TabIndex = 1;
            this.listPatient2.Click += new System.EventHandler(this.listPatient4_Click);
            // 
            // listPatient3
            // 
            this.listPatient3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.listPatient3.Location = new System.Drawing.Point(150, 547);
            this.listPatient3.Name = "listPatient3";
            this.listPatient3.Size = new System.Drawing.Size(2044, 211);
            this.listPatient3.TabIndex = 2;
            this.listPatient3.Click += new System.EventHandler(this.listPatient4_Click);
            // 
            // listPatient4
            // 
            this.listPatient4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.listPatient4.Location = new System.Drawing.Point(150, 788);
            this.listPatient4.Name = "listPatient4";
            this.listPatient4.Size = new System.Drawing.Size(2044, 211);
            this.listPatient4.TabIndex = 3;
            this.listPatient4.Click += new System.EventHandler(this.listPatient4_Click);
            // 
            // Patients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(2362, 1506);
            this.Controls.Add(this.listPatient4);
            this.Controls.Add(this.listPatient3);
            this.Controls.Add(this.listPatient2);
            this.Controls.Add(this.listPatient1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patients";
            this.Text = "Patients";
            this.ResumeLayout(false);

        }

        #endregion

        private ListPatient listPatient1;
        private ListPatient listPatient2;
        private ListPatient listPatient3;
        private ListPatient listPatient4;
    }
}