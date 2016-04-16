namespace GigsXML
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
            this.dgvGigs = new System.Windows.Forms.DataGridView();
            this.bandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.venue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAllGigs = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvBand = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBand)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGigs
            // 
            this.dgvGigs.AllowUserToAddRows = false;
            this.dgvGigs.AllowUserToDeleteRows = false;
            this.dgvGigs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGigs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bandName,
            this.genre,
            this.venue,
            this.date,
            this.time});
            this.dgvGigs.Location = new System.Drawing.Point(3, 66);
            this.dgvGigs.Name = "dgvGigs";
            this.dgvGigs.ReadOnly = true;
            this.dgvGigs.Size = new System.Drawing.Size(543, 202);
            this.dgvGigs.TabIndex = 0;
            // 
            // bandName
            // 
            this.bandName.HeaderText = "Band Name";
            this.bandName.Name = "bandName";
            this.bandName.ReadOnly = true;
            // 
            // genre
            // 
            this.genre.HeaderText = "Genre";
            this.genre.Name = "genre";
            this.genre.ReadOnly = true;
            // 
            // venue
            // 
            this.venue.HeaderText = "Venue";
            this.venue.Name = "venue";
            this.venue.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // btnAllGigs
            // 
            this.btnAllGigs.Location = new System.Drawing.Point(3, 37);
            this.btnAllGigs.Name = "btnAllGigs";
            this.btnAllGigs.Size = new System.Drawing.Size(75, 23);
            this.btnAllGigs.TabIndex = 1;
            this.btnAllGigs.Text = "All Gigs";
            this.btnAllGigs.UseVisualStyleBackColor = true;
            this.btnAllGigs.Click += new System.EventHandler(this.btnAllGigs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hard Rock Only";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvBand
            // 
            this.dgvBand.AllowUserToAddRows = false;
            this.dgvBand.AllowUserToDeleteRows = false;
            this.dgvBand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bname,
            this.Role,
            this.Column1});
            this.dgvBand.Location = new System.Drawing.Point(3, 335);
            this.dgvBand.Name = "dgvBand";
            this.dgvBand.ReadOnly = true;
            this.dgvBand.Size = new System.Drawing.Size(343, 202);
            this.dgvBand.TabIndex = 3;
            this.dgvBand.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBand_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gig Dataview";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Band Dataview";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Show Alabama Shakes Members";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bname
            // 
            this.bname.HeaderText = "Member Name";
            this.bname.Name = "bname";
            this.bname.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Instruments";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Gigs This Month";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 609);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAllGigs);
            this.Controls.Add(this.dgvGigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGigs;
        private System.Windows.Forms.DataGridViewTextBoxColumn bandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn genre;
        private System.Windows.Forms.DataGridViewTextBoxColumn venue;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button btnAllGigs;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvBand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button3;

    }
}

