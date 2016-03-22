namespace BikesSubObs
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.lbRPM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCal = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbKM = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 14);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 36);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Speed:";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(166, 30);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(151, 20);
            this.txtSpeed.TabIndex = 2;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.lbRPM);
            this.gb1.Location = new System.Drawing.Point(13, 57);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(304, 123);
            this.gb1.TabIndex = 3;
            this.gb1.TabStop = false;
            this.gb1.Text = "RPM";
            // 
            // lbRPM
            // 
            this.lbRPM.AutoSize = true;
            this.lbRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRPM.Location = new System.Drawing.Point(114, 47);
            this.lbRPM.Name = "lbRPM";
            this.lbRPM.Size = new System.Drawing.Size(65, 37);
            this.lbRPM.TabIndex = 0;
            this.lbRPM.Text = "0.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCal);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(304, 123);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calories Per Hour";
            // 
            // lbCal
            // 
            this.lbCal.AutoSize = true;
            this.lbCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal.Location = new System.Drawing.Point(114, 47);
            this.lbCal.Name = "lbCal";
            this.lbCal.Size = new System.Drawing.Size(65, 37);
            this.lbCal.TabIndex = 0;
            this.lbCal.Text = "0.0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbKM);
            this.groupBox2.Location = new System.Drawing.Point(13, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(304, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kilometres Per Hour";
            // 
            // lbKM
            // 
            this.lbKM.AutoSize = true;
            this.lbKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKM.Location = new System.Drawing.Point(114, 47);
            this.lbKM.Name = "lbKM";
            this.lbKM.Size = new System.Drawing.Size(65, 37);
            this.lbKM.TabIndex = 0;
            this.lbKM.Text = "0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 449);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label lbRPM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbCal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbKM;
    }
}

