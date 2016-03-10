namespace IN710_4._1_Animal_Shelter_Solution_2014
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
            this.rdoRabbit = new System.Windows.Forms.RadioButton();
            this.rdoDuck = new System.Windows.Forms.RadioButton();
            this.rdoDog = new System.Windows.Forms.RadioButton();
            this.rdoCat = new System.Windows.Forms.RadioButton();
            this.lbOut = new System.Windows.Forms.ListBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoRabbit);
            this.groupBox1.Controls.Add(this.rdoDuck);
            this.groupBox1.Controls.Add(this.rdoDog);
            this.groupBox1.Controls.Add(this.rdoCat);
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 210);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // rdoRabbit
            // 
            this.rdoRabbit.AutoSize = true;
            this.rdoRabbit.Location = new System.Drawing.Point(22, 165);
            this.rdoRabbit.Name = "rdoRabbit";
            this.rdoRabbit.Size = new System.Drawing.Size(85, 27);
            this.rdoRabbit.TabIndex = 3;
            this.rdoRabbit.TabStop = true;
            this.rdoRabbit.Text = "Rabbits";
            this.rdoRabbit.UseVisualStyleBackColor = true;
            // 
            // rdoDuck
            // 
            this.rdoDuck.AutoSize = true;
            this.rdoDuck.Location = new System.Drawing.Point(22, 120);
            this.rdoDuck.Name = "rdoDuck";
            this.rdoDuck.Size = new System.Drawing.Size(75, 27);
            this.rdoDuck.TabIndex = 2;
            this.rdoDuck.TabStop = true;
            this.rdoDuck.Text = "Ducks";
            this.rdoDuck.UseVisualStyleBackColor = true;
            // 
            // rdoDog
            // 
            this.rdoDog.AutoSize = true;
            this.rdoDog.Location = new System.Drawing.Point(22, 75);
            this.rdoDog.Name = "rdoDog";
            this.rdoDog.Size = new System.Drawing.Size(67, 27);
            this.rdoDog.TabIndex = 1;
            this.rdoDog.TabStop = true;
            this.rdoDog.Text = "Dogs";
            this.rdoDog.UseVisualStyleBackColor = true;
            // 
            // rdoCat
            // 
            this.rdoCat.AutoSize = true;
            this.rdoCat.Location = new System.Drawing.Point(22, 30);
            this.rdoCat.Name = "rdoCat";
            this.rdoCat.Size = new System.Drawing.Size(61, 27);
            this.rdoCat.TabIndex = 0;
            this.rdoCat.TabStop = true;
            this.rdoCat.Text = "Cats";
            this.rdoCat.UseVisualStyleBackColor = true;
            // 
            // lbOut
            // 
            this.lbOut.FormattingEnabled = true;
            this.lbOut.ItemHeight = 22;
            this.lbOut.Location = new System.Drawing.Point(8, 243);
            this.lbOut.Name = "lbOut";
            this.lbOut.Size = new System.Drawing.Size(195, 334);
            this.lbOut.TabIndex = 1;
            // 
            // pb1
            // 
            this.pb1.Location = new System.Drawing.Point(275, 33);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(256, 256);
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(540, 33);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(256, 256);
            this.pb2.TabIndex = 3;
            this.pb2.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(275, 300);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(256, 256);
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Location = new System.Drawing.Point(540, 300);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(256, 256);
            this.pb4.TabIndex = 5;
            this.pb4.TabStop = false;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 601);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(192, 42);
            this.btnShow.TabIndex = 6;
            this.btnShow.Text = "Show Pets!";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 654);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbOut);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoRabbit;
        private System.Windows.Forms.RadioButton rdoDuck;
        private System.Windows.Forms.RadioButton rdoDog;
        private System.Windows.Forms.RadioButton rdoCat;
        private System.Windows.Forms.ListBox lbOut;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.Button btnShow;
    }
}

