namespace WindowsFormsApplication1
{
    partial class FormCalendar
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnForw = new System.Windows.Forms.Button();
            this.lblMonth = new System.Windows.Forms.Label();
            this.monthPanel1 = new WindowsFormsApplication1.MonthPanel();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(54, 13);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 23);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Text = "button1";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnForw
            // 
            this.btnForw.Location = new System.Drawing.Point(616, 3);
            this.btnForw.Name = "btnForw";
            this.btnForw.Size = new System.Drawing.Size(75, 23);
            this.btnForw.TabIndex = 2;
            this.btnForw.Text = "button2";
            this.btnForw.UseVisualStyleBackColor = true;
            this.btnForw.Click += new System.EventHandler(this.btnForw_Click);
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Location = new System.Drawing.Point(297, 13);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(35, 13);
            this.lblMonth.TabIndex = 3;
            this.lblMonth.Text = "label1";
            // 
            // monthPanel1
            // 
            this.monthPanel1.Location = new System.Drawing.Point(0, 54);
            this.monthPanel1.Name = "monthPanel1";
            this.monthPanel1.Size = new System.Drawing.Size(775, 511);
            this.monthPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 566);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.btnForw);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.monthPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MonthPanel monthPanel1;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnForw;
        private System.Windows.Forms.Label lblMonth;


    }
}