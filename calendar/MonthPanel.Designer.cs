namespace WindowsFormsApplication1
{
    partial class MonthPanel
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
            this.weekPanel1 = new WindowsFormsApplication1.WeekPanel();
            this.weekPanel2 = new WindowsFormsApplication1.WeekPanel();
            this.weekPanel3 = new WindowsFormsApplication1.WeekPanel();
            this.weekPanel4 = new WindowsFormsApplication1.WeekPanel();
            this.weekPanel5 = new WindowsFormsApplication1.WeekPanel();
            this.weekPanel6 = new WindowsFormsApplication1.WeekPanel();
            this.SuspendLayout();
            // 
            // weekPanel1
            // 
            this.weekPanel1.Location = new System.Drawing.Point(0, 0);
            this.weekPanel1.Name = "weekPanel1";
            this.weekPanel1.Size = new System.Drawing.Size(773, 88);
            this.weekPanel1.TabIndex = 0;
            // 
            // weekPanel2
            // 
            this.weekPanel2.Location = new System.Drawing.Point(0, 83);
            this.weekPanel2.Name = "weekPanel2";
            this.weekPanel2.Size = new System.Drawing.Size(773, 88);
            this.weekPanel2.TabIndex = 1;
            // 
            // weekPanel3
            // 
            this.weekPanel3.Location = new System.Drawing.Point(0, 168);
            this.weekPanel3.Name = "weekPanel3";
            this.weekPanel3.Size = new System.Drawing.Size(773, 88);
            this.weekPanel3.TabIndex = 2;
            // 
            // weekPanel4
            // 
            this.weekPanel4.Location = new System.Drawing.Point(0, 253);
            this.weekPanel4.Name = "weekPanel4";
            this.weekPanel4.Size = new System.Drawing.Size(773, 88);
            this.weekPanel4.TabIndex = 3;
            // 
            // weekPanel5
            // 
            this.weekPanel5.Location = new System.Drawing.Point(0, 337);
            this.weekPanel5.Name = "weekPanel5";
            this.weekPanel5.Size = new System.Drawing.Size(773, 88);
            this.weekPanel5.TabIndex = 4;
            // 
            // weekPanel6
            // 
            this.weekPanel6.Location = new System.Drawing.Point(0, 421);
            this.weekPanel6.Name = "weekPanel6";
            this.weekPanel6.Size = new System.Drawing.Size(773, 88);
            this.weekPanel6.TabIndex = 5;
            // 
            // MonthPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.weekPanel6);
            this.Controls.Add(this.weekPanel5);
            this.Controls.Add(this.weekPanel4);
            this.Controls.Add(this.weekPanel3);
            this.Controls.Add(this.weekPanel2);
            this.Controls.Add(this.weekPanel1);
            this.Name = "MonthPanel";
            this.Size = new System.Drawing.Size(777, 510);
            this.Load += new System.EventHandler(this.MonthPanel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private WeekPanel weekPanel1;
        private WeekPanel weekPanel2;
        private WeekPanel weekPanel3;
        private WeekPanel weekPanel4;
        private WeekPanel weekPanel5;
        private WeekPanel weekPanel6;

    }
}
