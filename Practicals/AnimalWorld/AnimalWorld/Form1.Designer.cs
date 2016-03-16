namespace AnimalWorld
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
            this.lbDisplayBox = new System.Windows.Forms.ListBox();
            this.btnAU = new System.Windows.Forms.Button();
            this.btnNA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDisplayBox
            // 
            this.lbDisplayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisplayBox.FormattingEnabled = true;
            this.lbDisplayBox.ItemHeight = 29;
            this.lbDisplayBox.Location = new System.Drawing.Point(249, 12);
            this.lbDisplayBox.Name = "lbDisplayBox";
            this.lbDisplayBox.Size = new System.Drawing.Size(502, 410);
            this.lbDisplayBox.TabIndex = 4;
            // 
            // btnAU
            // 
            this.btnAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAU.Location = new System.Drawing.Point(758, 12);
            this.btnAU.Name = "btnAU";
            this.btnAU.Size = new System.Drawing.Size(140, 98);
            this.btnAU.TabIndex = 5;
            this.btnAU.Text = "Australia";
            this.btnAU.UseVisualStyleBackColor = true;
            this.btnAU.Click += new System.EventHandler(this.btnAU_Click);
            // 
            // btnNA
            // 
            this.btnNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNA.Location = new System.Drawing.Point(758, 116);
            this.btnNA.Name = "btnNA";
            this.btnNA.Size = new System.Drawing.Size(140, 98);
            this.btnNA.TabIndex = 6;
            this.btnNA.Text = "North America";
            this.btnNA.UseVisualStyleBackColor = true;
            this.btnNA.Click += new System.EventHandler(this.btnNA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 434);
            this.Controls.Add(this.btnNA);
            this.Controls.Add(this.btnAU);
            this.Controls.Add(this.lbDisplayBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDisplayBox;
        private System.Windows.Forms.Button btnAU;
        private System.Windows.Forms.Button btnNA;
    }
}

