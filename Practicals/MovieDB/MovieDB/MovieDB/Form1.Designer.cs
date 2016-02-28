namespace MovieDB
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
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.txtAddYear = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.txtAddDirector = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDelMovie = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDeleteYear = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPrintAll = new System.Windows.Forms.Button();
            this.lbShowAll = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Location = new System.Drawing.Point(12, 12);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(118, 23);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAddYear
            // 
            this.txtAddYear.Location = new System.Drawing.Point(191, 12);
            this.txtAddYear.Name = "txtAddYear";
            this.txtAddYear.Size = new System.Drawing.Size(234, 20);
            this.txtAddYear.TabIndex = 1;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(191, 39);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(234, 20);
            this.txtAddTitle.TabIndex = 2;
            // 
            // txtAddDirector
            // 
            this.txtAddDirector.Location = new System.Drawing.Point(191, 66);
            this.txtAddDirector.Name = "txtAddDirector";
            this.txtAddDirector.Size = new System.Drawing.Size(234, 20);
            this.txtAddDirector.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Year:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Title:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Director:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDelMovie
            // 
            this.btnDelMovie.Location = new System.Drawing.Point(12, 122);
            this.btnDelMovie.Name = "btnDelMovie";
            this.btnDelMovie.Size = new System.Drawing.Size(118, 23);
            this.btnDelMovie.TabIndex = 7;
            this.btnDelMovie.Text = "Delete Movie";
            this.btnDelMovie.UseVisualStyleBackColor = true;
            this.btnDelMovie.Click += new System.EventHandler(this.btnDelMovie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Year:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtDeleteYear
            // 
            this.txtDeleteYear.Location = new System.Drawing.Point(191, 124);
            this.txtDeleteYear.Name = "txtDeleteYear";
            this.txtDeleteYear.Size = new System.Drawing.Size(234, 20);
            this.txtDeleteYear.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Year:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(191, 169);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(234, 20);
            this.txtSearchYear.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 167);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 23);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPrintAll
            // 
            this.btnPrintAll.Location = new System.Drawing.Point(12, 214);
            this.btnPrintAll.Name = "btnPrintAll";
            this.btnPrintAll.Size = new System.Drawing.Size(118, 23);
            this.btnPrintAll.TabIndex = 13;
            this.btnPrintAll.Text = "Print All";
            this.btnPrintAll.UseVisualStyleBackColor = true;
            this.btnPrintAll.Click += new System.EventHandler(this.btnPrintAll_Click);
            // 
            // lbShowAll
            // 
            this.lbShowAll.FormattingEnabled = true;
            this.lbShowAll.Location = new System.Drawing.Point(136, 214);
            this.lbShowAll.Name = "lbShowAll";
            this.lbShowAll.Size = new System.Drawing.Size(289, 147);
            this.lbShowAll.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(437, 376);
            this.Controls.Add(this.lbShowAll);
            this.Controls.Add(this.btnPrintAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDeleteYear);
            this.Controls.Add(this.btnDelMovie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAddDirector);
            this.Controls.Add(this.txtAddTitle);
            this.Controls.Add(this.txtAddYear);
            this.Controls.Add(this.btnAddMovie);
            this.Name = "Form1";
            this.Text = "Movie Database";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.TextBox txtAddYear;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.TextBox txtAddDirector;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDelMovie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeleteYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPrintAll;
        private System.Windows.Forms.ListBox lbShowAll;
    }
}

