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
            this.dvgBand = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBand)).BeginInit();
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
            // dvgBand
            // 
            this.dvgBand.AllowUserToAddRows = false;
            this.dvgBand.AllowUserToDeleteRows = false;
            this.dvgBand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgBand.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bname,
            this.Role,
            this.Column1});
            this.dvgBand.Location = new System.Drawing.Point(3, 304);
            this.dvgBand.Name = "dvgBand";
            this.dvgBand.ReadOnly = true;
            this.dvgBand.Size = new System.Drawing.Size(343, 202);
            this.dvgBand.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(7, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Band Dataview";
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
            this.Column1.HeaderText = "Instruments (If Any)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dvgBand);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAllGigs);
            this.Controls.Add(this.dgvGigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgBand)).EndInit();
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
        private System.Windows.Forms.DataGridView dvgBand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;

    }
}

