namespace MixAndMatch
{
    partial class CharacterMaker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterMaker));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.cbFeet = new System.Windows.Forms.ComboBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.pbHead = new System.Windows.Forms.PictureBox();
            this.pbBody = new System.Windows.Forms.PictureBox();
            this.pbFeet = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Head:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Body:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Legs:";
            // 
            // cbHead
            // 
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Location = new System.Drawing.Point(352, 13);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(121, 21);
            this.cbHead.TabIndex = 3;
            // 
            // cbBody
            // 
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(352, 70);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(121, 21);
            this.cbBody.TabIndex = 4;
            // 
            // cbFeet
            // 
            this.cbFeet.FormattingEnabled = true;
            this.cbFeet.Location = new System.Drawing.Point(352, 123);
            this.cbFeet.Name = "cbFeet";
            this.cbFeet.Size = new System.Drawing.Size(121, 21);
            this.cbFeet.TabIndex = 5;
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(303, 175);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(170, 43);
            this.btnGen.TabIndex = 6;
            this.btnGen.Text = "Make Character!";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // pbHead
            // 
            this.pbHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHead.Image = ((System.Drawing.Image)(resources.GetObject("pbHead.Image")));
            this.pbHead.Location = new System.Drawing.Point(13, 13);
            this.pbHead.Name = "pbHead";
            this.pbHead.Size = new System.Drawing.Size(272, 170);
            this.pbHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHead.TabIndex = 7;
            this.pbHead.TabStop = false;
            // 
            // pbBody
            // 
            this.pbBody.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbBody.Image = ((System.Drawing.Image)(resources.GetObject("pbBody.Image")));
            this.pbBody.Location = new System.Drawing.Point(13, 175);
            this.pbBody.Name = "pbBody";
            this.pbBody.Size = new System.Drawing.Size(272, 170);
            this.pbBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBody.TabIndex = 8;
            this.pbBody.TabStop = false;
            // 
            // pbFeet
            // 
            this.pbFeet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFeet.Image = ((System.Drawing.Image)(resources.GetObject("pbFeet.Image")));
            this.pbFeet.Location = new System.Drawing.Point(13, 334);
            this.pbFeet.Name = "pbFeet";
            this.pbFeet.Size = new System.Drawing.Size(272, 170);
            this.pbFeet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFeet.TabIndex = 9;
            this.pbFeet.TabStop = false;
            // 
            // CharacterMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 508);
            this.Controls.Add(this.pbFeet);
            this.Controls.Add(this.pbBody);
            this.Controls.Add(this.pbHead);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.cbFeet);
            this.Controls.Add(this.cbBody);
            this.Controls.Add(this.cbHead);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CharacterMaker";
            this.Text = "Mix N Match";
            ((System.ComponentModel.ISupportInitialize)(this.pbHead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFeet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.ComboBox cbBody;
        private System.Windows.Forms.ComboBox cbFeet;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.PictureBox pbHead;
        private System.Windows.Forms.PictureBox pbBody;
        private System.Windows.Forms.PictureBox pbFeet;
    }
}

