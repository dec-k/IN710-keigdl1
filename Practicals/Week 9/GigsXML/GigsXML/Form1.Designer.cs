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
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).BeginInit();
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
            this.dgvGigs.Size = new System.Drawing.Size(543, 277);
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
            this.btnAllGigs.Location = new System.Drawing.Point(12, 27);
            this.btnAllGigs.Name = "btnAllGigs";
            this.btnAllGigs.Size = new System.Drawing.Size(75, 23);
            this.btnAllGigs.TabIndex = 1;
            this.btnAllGigs.Text = "All Gigs";
            this.btnAllGigs.UseVisualStyleBackColor = true;
            this.btnAllGigs.Click += new System.EventHandler(this.btnAllGigs_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Hard Rock Only";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 467);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAllGigs);
            this.Controls.Add(this.dgvGigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGigs)).EndInit();
            this.ResumeLayout(false);

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

    }
}

