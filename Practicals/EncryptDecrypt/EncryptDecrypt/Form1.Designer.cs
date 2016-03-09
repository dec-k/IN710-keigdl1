namespace EncryptDecrypt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEncString = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rdoROT13 = new System.Windows.Forms.RadioButton();
            this.rdoRev = new System.Windows.Forms.RadioButton();
            this.btnEnc = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text for Encryption:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtEncString
            // 
            this.txtEncString.Location = new System.Drawing.Point(13, 26);
            this.txtEncString.Name = "txtEncString";
            this.txtEncString.Size = new System.Drawing.Size(253, 20);
            this.txtEncString.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rdoRev);
            this.panel1.Controls.Add(this.rdoROT13);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(13, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 89);
            this.panel1.TabIndex = 2;
            this.panel1.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Encryption Type:";
            // 
            // rdoROT13
            // 
            this.rdoROT13.AutoSize = true;
            this.rdoROT13.Checked = true;
            this.rdoROT13.Location = new System.Drawing.Point(18, 31);
            this.rdoROT13.Name = "rdoROT13";
            this.rdoROT13.Size = new System.Drawing.Size(60, 17);
            this.rdoROT13.TabIndex = 4;
            this.rdoROT13.TabStop = true;
            this.rdoROT13.Text = "ROT13";
            this.rdoROT13.UseVisualStyleBackColor = true;
            // 
            // rdoRev
            // 
            this.rdoRev.AutoSize = true;
            this.rdoRev.Location = new System.Drawing.Point(18, 55);
            this.rdoRev.Name = "rdoRev";
            this.rdoRev.Size = new System.Drawing.Size(67, 17);
            this.rdoRev.TabIndex = 5;
            this.rdoRev.Text = "Reversal";
            this.rdoRev.UseVisualStyleBackColor = true;
            // 
            // btnEnc
            // 
            this.btnEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnc.Location = new System.Drawing.Point(141, 52);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(125, 89);
            this.btnEnc.TabIndex = 3;
            this.btnEnc.Text = "Encrypt";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Enabled = false;
            this.txtOutput.Location = new System.Drawing.Point(12, 166);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(253, 20);
            this.txtOutput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Encrypted Output:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 200);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEncString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox txtEncString;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdoRev;
        private System.Windows.Forms.RadioButton rdoROT13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnc;
        protected internal System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
    }
}

