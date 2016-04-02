namespace ProgressDelegate
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
            this.rdoSpinner = new System.Windows.Forms.RadioButton();
            this.rdoProgressBar = new System.Windows.Forms.RadioButton();
            this.rdoTrackbar = new System.Windows.Forms.RadioButton();
            this.btnTestProgress = new System.Windows.Forms.Button();
            this.nudTest = new System.Windows.Forms.NumericUpDown();
            this.progTest = new System.Windows.Forms.ProgressBar();
            this.trackTest = new System.Windows.Forms.TrackBar();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTest)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoTrackbar);
            this.groupBox1.Controls.Add(this.rdoProgressBar);
            this.groupBox1.Controls.Add(this.rdoSpinner);
            this.groupBox1.Location = new System.Drawing.Point(302, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Feedback";
            // 
            // rdoSpinner
            // 
            this.rdoSpinner.AutoSize = true;
            this.rdoSpinner.Location = new System.Drawing.Point(7, 20);
            this.rdoSpinner.Name = "rdoSpinner";
            this.rdoSpinner.Size = new System.Drawing.Size(119, 17);
            this.rdoSpinner.TabIndex = 0;
            this.rdoSpinner.TabStop = true;
            this.rdoSpinner.Text = "\"Numeric UpDown\"";
            this.rdoSpinner.UseVisualStyleBackColor = true;
            // 
            // rdoProgressBar
            // 
            this.rdoProgressBar.AutoSize = true;
            this.rdoProgressBar.Location = new System.Drawing.Point(7, 43);
            this.rdoProgressBar.Name = "rdoProgressBar";
            this.rdoProgressBar.Size = new System.Drawing.Size(85, 17);
            this.rdoProgressBar.TabIndex = 1;
            this.rdoProgressBar.TabStop = true;
            this.rdoProgressBar.Text = "Progress Bar";
            this.rdoProgressBar.UseVisualStyleBackColor = true;
            // 
            // rdoTrackbar
            // 
            this.rdoTrackbar.AutoSize = true;
            this.rdoTrackbar.Location = new System.Drawing.Point(7, 66);
            this.rdoTrackbar.Name = "rdoTrackbar";
            this.rdoTrackbar.Size = new System.Drawing.Size(72, 17);
            this.rdoTrackbar.TabIndex = 2;
            this.rdoTrackbar.TabStop = true;
            this.rdoTrackbar.Text = "Track Bar";
            this.rdoTrackbar.UseVisualStyleBackColor = true;
            // 
            // btnTestProgress
            // 
            this.btnTestProgress.Location = new System.Drawing.Point(302, 112);
            this.btnTestProgress.Name = "btnTestProgress";
            this.btnTestProgress.Size = new System.Drawing.Size(200, 23);
            this.btnTestProgress.TabIndex = 1;
            this.btnTestProgress.Text = "Test Progress";
            this.btnTestProgress.UseVisualStyleBackColor = true;
            this.btnTestProgress.Click += new System.EventHandler(this.btnTestProgress_Click);
            // 
            // nudTest
            // 
            this.nudTest.Location = new System.Drawing.Point(12, 12);
            this.nudTest.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudTest.Name = "nudTest";
            this.nudTest.Size = new System.Drawing.Size(284, 20);
            this.nudTest.TabIndex = 2;
            // 
            // progTest
            // 
            this.progTest.Location = new System.Drawing.Point(12, 49);
            this.progTest.Maximum = 10;
            this.progTest.Name = "progTest";
            this.progTest.Size = new System.Drawing.Size(284, 23);
            this.progTest.TabIndex = 3;
            // 
            // trackTest
            // 
            this.trackTest.Location = new System.Drawing.Point(12, 90);
            this.trackTest.Name = "trackTest";
            this.trackTest.Size = new System.Drawing.Size(284, 45);
            this.trackTest.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 147);
            this.Controls.Add(this.trackTest);
            this.Controls.Add(this.progTest);
            this.Controls.Add(this.nudTest);
            this.Controls.Add(this.btnTestProgress);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoTrackbar;
        private System.Windows.Forms.RadioButton rdoProgressBar;
        private System.Windows.Forms.RadioButton rdoSpinner;
        private System.Windows.Forms.Button btnTestProgress;
        private System.Windows.Forms.NumericUpDown nudTest;
        private System.Windows.Forms.ProgressBar progTest;
        private System.Windows.Forms.TrackBar trackTest;
    }
}

