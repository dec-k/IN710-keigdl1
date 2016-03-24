namespace WeatherStation
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
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBaro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.ListBox();
            this.lbAverages = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbForecast = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(152, 42);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Readings";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Temperature (C):";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(15, 92);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(149, 20);
            this.txtTemp.TabIndex = 2;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(15, 149);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(149, 20);
            this.txtHumidity.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Humidity (%):";
            // 
            // txtBaro
            // 
            this.txtBaro.Location = new System.Drawing.Point(15, 207);
            this.txtBaro.Name = "txtBaro";
            this.txtBaro.Size = new System.Drawing.Size(149, 20);
            this.txtBaro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Barometric Pressure:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Temperature Information:";
            // 
            // lbTemp
            // 
            this.lbTemp.FormattingEnabled = true;
            this.lbTemp.Location = new System.Drawing.Point(214, 28);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(319, 82);
            this.lbTemp.TabIndex = 8;
            // 
            // lbAverages
            // 
            this.lbAverages.FormattingEnabled = true;
            this.lbAverages.Location = new System.Drawing.Point(214, 149);
            this.lbAverages.Name = "lbAverages";
            this.lbAverages.Size = new System.Drawing.Size(319, 82);
            this.lbAverages.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Temperature Averages:";
            // 
            // lbForecast
            // 
            this.lbForecast.FormattingEnabled = true;
            this.lbForecast.Location = new System.Drawing.Point(214, 280);
            this.lbForecast.Name = "lbForecast";
            this.lbForecast.Size = new System.Drawing.Size(319, 82);
            this.lbForecast.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Forecast:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 378);
            this.Controls.Add(this.lbForecast);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbAverages);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbTemp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBaro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBaro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbTemp;
        private System.Windows.Forms.ListBox lbAverages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbForecast;
        private System.Windows.Forms.Label label6;
    }
}

