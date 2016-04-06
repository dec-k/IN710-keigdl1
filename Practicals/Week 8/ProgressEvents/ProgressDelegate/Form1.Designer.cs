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
            this.btnTestProgress = new System.Windows.Forms.Button();
            this.nudTest = new System.Windows.Forms.NumericUpDown();
            this.progTest = new System.Windows.Forms.ProgressBar();
            this.trackTest = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTest)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTestProgress
            // 
            this.btnTestProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestProgress.Location = new System.Drawing.Point(302, 12);
            this.btnTestProgress.Name = "btnTestProgress";
            this.btnTestProgress.Size = new System.Drawing.Size(200, 123);
            this.btnTestProgress.TabIndex = 1;
            this.btnTestProgress.Text = "Increase The Progress!!";
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
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackTest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTestProgress;
        private System.Windows.Forms.NumericUpDown nudTest;
        private System.Windows.Forms.ProgressBar progTest;
        private System.Windows.Forms.TrackBar trackTest;
    }
}

