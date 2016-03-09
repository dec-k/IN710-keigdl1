namespace AnalogDigital
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
            this.components = new System.ComponentModel.Container();
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDigiTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdoDigital = new System.Windows.Forms.RadioButton();
            this.rdoAnalog = new System.Windows.Forms.RadioButton();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(12, 118);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(192, 192);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            this.analogClock1.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDigiTime
            // 
            this.lblDigiTime.AutoSize = true;
            this.lblDigiTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDigiTime.Location = new System.Drawing.Point(66, 201);
            this.lblDigiTime.Name = "lblDigiTime";
            this.lblDigiTime.Size = new System.Drawing.Size(85, 29);
            this.lblDigiTime.TabIndex = 1;
            this.lblDigiTime.Text = "label1";
            this.lblDigiTime.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Mode:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStartStop);
            this.panel1.Controls.Add(this.rdoAnalog);
            this.panel1.Controls.Add(this.rdoDigital);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 100);
            this.panel1.TabIndex = 3;
            // 
            // rdoDigital
            // 
            this.rdoDigital.AutoSize = true;
            this.rdoDigital.Location = new System.Drawing.Point(16, 33);
            this.rdoDigital.Name = "rdoDigital";
            this.rdoDigital.Size = new System.Drawing.Size(54, 17);
            this.rdoDigital.TabIndex = 3;
            this.rdoDigital.TabStop = true;
            this.rdoDigital.Text = "Digital";
            this.rdoDigital.UseVisualStyleBackColor = true;
            // 
            // rdoAnalog
            // 
            this.rdoAnalog.AutoSize = true;
            this.rdoAnalog.Location = new System.Drawing.Point(111, 33);
            this.rdoAnalog.Name = "rdoAnalog";
            this.rdoAnalog.Size = new System.Drawing.Size(58, 17);
            this.rdoAnalog.TabIndex = 4;
            this.rdoAnalog.TabStop = true;
            this.rdoAnalog.Text = "Analog";
            this.rdoAnalog.UseVisualStyleBackColor = true;
            // 
            // btnStartStop
            // 
            this.btnStartStop.Location = new System.Drawing.Point(16, 68);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(153, 24);
            this.btnStartStop.TabIndex = 5;
            this.btnStartStop.Text = "Start";
            this.btnStartStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblDigiTime);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "AnalogDigital";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDigiTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.RadioButton rdoAnalog;
        private System.Windows.Forms.RadioButton rdoDigital;

    }
}

