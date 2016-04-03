namespace PredicateDelegate
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
            this.btnGenSet = new System.Windows.Forms.Button();
            this.btnEvens = new System.Windows.Forms.Button();
            this.btnLessThanTen = new System.Windows.Forms.Button();
            this.lbFiltered = new System.Windows.Forms.ListBox();
            this.lbRands = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGenSet
            // 
            this.btnGenSet.Location = new System.Drawing.Point(12, 12);
            this.btnGenSet.Name = "btnGenSet";
            this.btnGenSet.Size = new System.Drawing.Size(138, 23);
            this.btnGenSet.TabIndex = 0;
            this.btnGenSet.Text = "Generate Set";
            this.btnGenSet.UseVisualStyleBackColor = true;
            this.btnGenSet.Click += new System.EventHandler(this.btnGenSet_Click);
            // 
            // btnEvens
            // 
            this.btnEvens.Location = new System.Drawing.Point(156, 12);
            this.btnEvens.Name = "btnEvens";
            this.btnEvens.Size = new System.Drawing.Size(138, 23);
            this.btnEvens.TabIndex = 1;
            this.btnEvens.Text = "Display Evens";
            this.btnEvens.UseVisualStyleBackColor = true;
            // 
            // btnLessThanTen
            // 
            this.btnLessThanTen.Location = new System.Drawing.Point(156, 41);
            this.btnLessThanTen.Name = "btnLessThanTen";
            this.btnLessThanTen.Size = new System.Drawing.Size(138, 23);
            this.btnLessThanTen.TabIndex = 2;
            this.btnLessThanTen.Text = "Display <10";
            this.btnLessThanTen.UseVisualStyleBackColor = true;
            // 
            // lbFiltered
            // 
            this.lbFiltered.FormattingEnabled = true;
            this.lbFiltered.Location = new System.Drawing.Point(156, 70);
            this.lbFiltered.Name = "lbFiltered";
            this.lbFiltered.Size = new System.Drawing.Size(137, 329);
            this.lbFiltered.TabIndex = 3;
            // 
            // lbRands
            // 
            this.lbRands.FormattingEnabled = true;
            this.lbRands.Location = new System.Drawing.Point(12, 70);
            this.lbRands.Name = "lbRands";
            this.lbRands.Size = new System.Drawing.Size(137, 329);
            this.lbRands.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 410);
            this.Controls.Add(this.lbRands);
            this.Controls.Add(this.lbFiltered);
            this.Controls.Add(this.btnLessThanTen);
            this.Controls.Add(this.btnEvens);
            this.Controls.Add(this.btnGenSet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenSet;
        private System.Windows.Forms.Button btnEvens;
        private System.Windows.Forms.Button btnLessThanTen;
        private System.Windows.Forms.ListBox lbFiltered;
        private System.Windows.Forms.ListBox lbRands;
    }
}

