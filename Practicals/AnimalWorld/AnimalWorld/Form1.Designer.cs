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
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.lbDisplayBox = new System.Windows.Forms.ListBox();
            this.btnAU = new System.Windows.Forms.Button();
            this.btnNA = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(230, 98);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(12, 116);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(230, 98);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(12, 220);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(230, 98);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(12, 324);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(230, 98);
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 434);
            this.Controls.Add(this.btnNA);
            this.Controls.Add(this.btnAU);
            this.Controls.Add(this.lbDisplayBox);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.ListBox lbDisplayBox;
        private System.Windows.Forms.Button btnAU;
        private System.Windows.Forms.Button btnNA;
    }
}

