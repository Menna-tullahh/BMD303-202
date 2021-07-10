
namespace physical_therapy_system
{
    partial class ucAddNewUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddNewUser));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pAddress = new System.Windows.Forms.RichTextBox();
            this.pJob = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pNote = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnNextRe = new System.Windows.Forms.Button();
            this.pName = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FemaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pNationalID = new System.Windows.Forms.RichTextBox();
            this.pEmail = new System.Windows.Forms.MaskedTextBox();
            this.pPhone1 = new System.Windows.Forms.MaskedTextBox();
            this.pDOB = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAddNew = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panelAddNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Location = new System.Drawing.Point(94, 1117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 268);
            this.panel2.TabIndex = 9;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label12.Location = new System.Drawing.Point(49, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(328, 55);
            this.label12.TabIndex = 4;
            this.label12.Text = "Upload Photo";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 836);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 46);
            this.label8.TabIndex = 18;
            this.label8.Text = "National ID: *";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pAddress
            // 
            this.pAddress.BackColor = System.Drawing.SystemColors.Window;
            this.pAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAddress.EnableAutoDragDrop = true;
            this.pAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pAddress.Location = new System.Drawing.Point(1374, 421);
            this.pAddress.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pAddress.Multiline = false;
            this.pAddress.Name = "pAddress";
            this.pAddress.Size = new System.Drawing.Size(550, 53);
            this.pAddress.TabIndex = 15;
            this.pAddress.Text = "";
            this.pAddress.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // pJob
            // 
            this.pJob.BackColor = System.Drawing.SystemColors.Window;
            this.pJob.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pJob.EnableAutoDragDrop = true;
            this.pJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pJob.Location = new System.Drawing.Point(1374, 214);
            this.pJob.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pJob.Multiline = false;
            this.pJob.Name = "pJob";
            this.pJob.Size = new System.Drawing.Size(550, 53);
            this.pJob.TabIndex = 14;
            this.pJob.Text = "";
            this.pJob.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.panel3.Controls.Add(this.pNote);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(1004, 1117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(801, 268);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pNote
            // 
            this.pNote.BackColor = System.Drawing.SystemColors.Window;
            this.pNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNote.EnableAutoDragDrop = true;
            this.pNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNote.Location = new System.Drawing.Point(176, 50);
            this.pNote.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pNote.Name = "pNote";
            this.pNote.Size = new System.Drawing.Size(561, 179);
            this.pNote.TabIndex = 11;
            this.pNote.Text = "";
            this.pNote.TextChanged += new System.EventHandler(this.richTextBox11_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(35, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 46);
            this.label13.TabIndex = 7;
            this.label13.Text = "Note:";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // btnNextRe
            // 
            this.btnNextRe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNextRe.FlatAppearance.BorderSize = 0;
            this.btnNextRe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnNextRe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnNextRe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextRe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextRe.ForeColor = System.Drawing.Color.Black;
            this.btnNextRe.Image = ((System.Drawing.Image)(resources.GetObject("btnNextRe.Image")));
            this.btnNextRe.Location = new System.Drawing.Point(1887, 1195);
            this.btnNextRe.Name = "btnNextRe";
            this.btnNextRe.Size = new System.Drawing.Size(389, 151);
            this.btnNextRe.TabIndex = 10;
            this.btnNextRe.Text = "Next Page";
            this.btnNextRe.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNextRe.UseVisualStyleBackColor = false;
            this.btnNextRe.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // pName
            // 
            this.pName.BackColor = System.Drawing.SystemColors.Window;
            this.pName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pName.EnableAutoDragDrop = true;
            this.pName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pName.Location = new System.Drawing.Point(407, 218);
            this.pName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pName.Multiline = false;
            this.pName.Name = "pName";
            this.pName.Size = new System.Drawing.Size(550, 53);
            this.pName.TabIndex = 10;
            this.pName.Text = "";
            this.pName.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(58, 630);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 46);
            this.label6.TabIndex = 8;
            this.label6.Text = "Phone Number:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1128, 421);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 46);
            this.label5.TabIndex = 7;
            this.label5.Text = "Address";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1128, 835);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 46);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1128, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Job:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 46);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date of birth:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lblTitle.Location = new System.Drawing.Point(56, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(484, 55);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Personal information";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(44)))), ((int)(((byte)(58)))));
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.pNationalID);
            this.panel1.Controls.Add(this.pEmail);
            this.panel1.Controls.Add(this.pPhone1);
            this.panel1.Controls.Add(this.pDOB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pAddress);
            this.panel1.Controls.Add(this.pJob);
            this.panel1.Controls.Add(this.pName);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(87, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2189, 1021);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(1374, 628);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(550, 53);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(550, 53);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(550, 53);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "Gender";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoToolTip = true;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MaleToolStripMenuItem,
            this.FemaleToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(140, 49);
            this.toolStripMenuItem1.Text = "Gender";
            // 
            // MaleToolStripMenuItem
            // 
            this.MaleToolStripMenuItem.CheckOnClick = true;
            this.MaleToolStripMenuItem.Name = "MaleToolStripMenuItem";
            this.MaleToolStripMenuItem.Size = new System.Drawing.Size(279, 54);
            this.MaleToolStripMenuItem.Text = "Male";
            this.MaleToolStripMenuItem.Click += new System.EventHandler(this.MaleToolStripMenuItem_Click);
            // 
            // FemaleToolStripMenuItem
            // 
            this.FemaleToolStripMenuItem.CheckOnClick = true;
            this.FemaleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FemaleToolStripMenuItem.Name = "FemaleToolStripMenuItem";
            this.FemaleToolStripMenuItem.Size = new System.Drawing.Size(279, 54);
            this.FemaleToolStripMenuItem.Text = "Female";
            this.FemaleToolStripMenuItem.Click += new System.EventHandler(this.FemaleToolStripMenuItem_Click);
            // 
            // pNationalID
            // 
            this.pNationalID.BackColor = System.Drawing.SystemColors.Window;
            this.pNationalID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pNationalID.EnableAutoDragDrop = true;
            this.pNationalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pNationalID.Location = new System.Drawing.Point(407, 835);
            this.pNationalID.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.pNationalID.MaxLength = 14;
            this.pNationalID.Multiline = false;
            this.pNationalID.Name = "pNationalID";
            this.pNationalID.Size = new System.Drawing.Size(550, 53);
            this.pNationalID.TabIndex = 30;
            this.pNationalID.Text = "";
            this.pNationalID.TextChanged += new System.EventHandler(this.pNationalID_TextChanged);
            // 
            // pEmail
            // 
            this.pEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEmail.Location = new System.Drawing.Point(1374, 842);
            this.pEmail.Mask = "aaaaaaaaaaaaaaaaaaaaa@aaaaaaa.aaaa";
            this.pEmail.MaximumSize = new System.Drawing.Size(550, 53);
            this.pEmail.MinimumSize = new System.Drawing.Size(550, 53);
            this.pEmail.Name = "pEmail";
            this.pEmail.Size = new System.Drawing.Size(550, 38);
            this.pEmail.TabIndex = 29;
            this.pEmail.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.pEmail_MaskInputRejected);
            this.pEmail.Enter += new System.EventHandler(this.pEmail_Enter);
            // 
            // pPhone1
            // 
            this.pPhone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPhone1.Location = new System.Drawing.Point(407, 626);
            this.pPhone1.Mask = "\\0\\1000000000";
            this.pPhone1.MaximumSize = new System.Drawing.Size(550, 53);
            this.pPhone1.MinimumSize = new System.Drawing.Size(550, 53);
            this.pPhone1.Name = "pPhone1";
            this.pPhone1.Size = new System.Drawing.Size(550, 38);
            this.pPhone1.TabIndex = 28;
            this.pPhone1.Enter += new System.EventHandler(this.pPhone1_Enter);
            // 
            // pDOB
            // 
            this.pDOB.Location = new System.Drawing.Point(407, 421);
            this.pDOB.MaximumSize = new System.Drawing.Size(550, 53);
            this.pDOB.MinimumSize = new System.Drawing.Size(550, 53);
            this.pDOB.Name = "pDOB";
            this.pDOB.Size = new System.Drawing.Size(550, 53);
            this.pDOB.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1128, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 46);
            this.label7.TabIndex = 9;
            this.label7.Text = "Gender:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Patient Name: *";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelAddNew
            // 
            this.panelAddNew.Controls.Add(this.panel2);
            this.panelAddNew.Controls.Add(this.panel1);
            this.panelAddNew.Controls.Add(this.panel3);
            this.panelAddNew.Controls.Add(this.btnNextRe);
            this.panelAddNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAddNew.Location = new System.Drawing.Point(0, 0);
            this.panelAddNew.Name = "panelAddNew";
            this.panelAddNew.Size = new System.Drawing.Size(2353, 1415);
            this.panelAddNew.TabIndex = 12;
            this.panelAddNew.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAddNew_Paint);
            // 
            // ucAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.panelAddNew);
            this.Name = "ucAddNewUser";
            this.Size = new System.Drawing.Size(2353, 1415);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelAddNew.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox pAddress;
        private System.Windows.Forms.RichTextBox pJob;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox pNote;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnNextRe;
        private System.Windows.Forms.RichTextBox pName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelAddNew;
        private System.Windows.Forms.DateTimePicker pDOB;
        private System.Windows.Forms.MaskedTextBox pEmail;
        public System.Windows.Forms.MaskedTextBox pPhone1;
        private System.Windows.Forms.RichTextBox pNationalID;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FemaleToolStripMenuItem;
    }
}
