
namespace physical_therapy_system
{
    partial class ucCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucCalendar));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnNextT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(7, 6);
            this.monthCalendar1.Location = new System.Drawing.Point(185, 91);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinimumSize = new System.Drawing.Size(1469, 1106);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowToday = false;
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // btnNextT
            // 
            this.btnNextT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnNextT.FlatAppearance.BorderSize = 0;
            this.btnNextT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnNextT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnNextT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextT.ForeColor = System.Drawing.Color.Black;
            this.btnNextT.Image = ((System.Drawing.Image)(resources.GetObject("btnNextT.Image")));
            this.btnNextT.Location = new System.Drawing.Point(1628, 1218);
            this.btnNextT.Name = "btnNextT";
            this.btnNextT.Size = new System.Drawing.Size(389, 151);
            this.btnNextT.TabIndex = 28;
            this.btnNextT.Text = "Next Page";
            this.btnNextT.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnNextT.UseVisualStyleBackColor = false;
            this.btnNextT.Click += new System.EventHandler(this.btnNextT_Click);
            // 
            // ucCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.btnNextT);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "ucCalendar";
            this.Size = new System.Drawing.Size(2353, 1415);
            this.Load += new System.EventHandler(this.ucCalendar_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnNextT;
    }
}
