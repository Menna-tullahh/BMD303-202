
namespace physical_therapy_system
{
    partial class ListPatient
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListPatient));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IblTitle = new System.Windows.Forms.Label();
            this.IblMessage = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(216, 211);
            this.panel1.TabIndex = 0;
            // 
            // IblTitle
            // 
            this.IblTitle.AutoSize = true;
            this.IblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.IblTitle.Location = new System.Drawing.Point(295, 27);
            this.IblTitle.Name = "IblTitle";
            this.IblTitle.Size = new System.Drawing.Size(235, 39);
            this.IblTitle.TabIndex = 2;
            this.IblTitle.Text = "Patient Name";
            this.IblTitle.MouseEnter += new System.EventHandler(this.ListPatient_MouseEnter);
            this.IblTitle.MouseLeave += new System.EventHandler(this.ListPatient_MouseLeave);
            // 
            // IblMessage
            // 
            this.IblMessage.AutoSize = true;
            this.IblMessage.ForeColor = System.Drawing.SystemColors.Control;
            this.IblMessage.Location = new System.Drawing.Point(296, 105);
            this.IblMessage.Name = "IblMessage";
            this.IblMessage.Size = new System.Drawing.Size(93, 32);
            this.IblMessage.TabIndex = 5;
            this.IblMessage.Text = "label3";
            this.IblMessage.Click += new System.EventHandler(this.IblMessage_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(-8, 201);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2052, 15);
            this.panel2.TabIndex = 6;
            // 
            // ListPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.IblMessage);
            this.Controls.Add(this.IblTitle);
            this.Controls.Add(this.panel1);
            this.Name = "ListPatient";
            this.Size = new System.Drawing.Size(2044, 211);
            this.Load += new System.EventHandler(this.ListPatient_Load);
            this.Click += new System.EventHandler(this.ListPatient_Click);
            this.Leave += new System.EventHandler(this.ListPatient_Leave);
            this.MouseEnter += new System.EventHandler(this.ListPatient_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ListPatient_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IblTitle;
        private System.Windows.Forms.Label IblMessage;
        private System.Windows.Forms.Panel panel2;
    }
}
