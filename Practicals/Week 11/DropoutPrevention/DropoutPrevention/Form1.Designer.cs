namespace DropoutPrevention
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowPaper = new System.Windows.Forms.Button();
            this.btnDueSoon = new System.Windows.Forms.Button();
            this.btnAvg = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAvg);
            this.groupBox1.Controls.Add(this.btnDueSoon);
            this.groupBox1.Controls.Add(this.btnShowPaper);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // btnShowPaper
            // 
            this.btnShowPaper.Location = new System.Drawing.Point(6, 19);
            this.btnShowPaper.Name = "btnShowPaper";
            this.btnShowPaper.Size = new System.Drawing.Size(300, 23);
            this.btnShowPaper.TabIndex = 1;
            this.btnShowPaper.Text = "Show My Papers";
            this.btnShowPaper.UseVisualStyleBackColor = true;
            this.btnShowPaper.Click += new System.EventHandler(this.btnShowPaper_Click);
            // 
            // btnDueSoon
            // 
            this.btnDueSoon.Location = new System.Drawing.Point(6, 48);
            this.btnDueSoon.Name = "btnDueSoon";
            this.btnDueSoon.Size = new System.Drawing.Size(300, 23);
            this.btnDueSoon.TabIndex = 2;
            this.btnDueSoon.Text = "Due Soon";
            this.btnDueSoon.UseVisualStyleBackColor = true;
            this.btnDueSoon.Click += new System.EventHandler(this.btnDueSoon_Click);
            // 
            // btnAvg
            // 
            this.btnAvg.Location = new System.Drawing.Point(6, 77);
            this.btnAvg.Name = "btnAvg";
            this.btnAvg.Size = new System.Drawing.Size(300, 23);
            this.btnAvg.TabIndex = 3;
            this.btnAvg.Text = "Average Grades";
            this.btnAvg.UseVisualStyleBackColor = true;
            // 
            // lb
            // 
            this.lb.FormattingEnabled = true;
            this.lb.Location = new System.Drawing.Point(12, 129);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(312, 303);
            this.lb.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 452);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Assignment Calendar";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAvg;
        private System.Windows.Forms.Button btnDueSoon;
        private System.Windows.Forms.Button btnShowPaper;
        private System.Windows.Forms.ListBox lb;
    }
}

