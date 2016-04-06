namespace CustomHandlers
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
            this.btnTriggerHandlers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTriggerHandlers
            // 
            this.btnTriggerHandlers.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTriggerHandlers.Location = new System.Drawing.Point(12, 12);
            this.btnTriggerHandlers.Name = "btnTriggerHandlers";
            this.btnTriggerHandlers.Size = new System.Drawing.Size(260, 237);
            this.btnTriggerHandlers.TabIndex = 0;
            this.btnTriggerHandlers.Text = "UNLEASH THE HANDLERS";
            this.btnTriggerHandlers.UseVisualStyleBackColor = true;
            this.btnTriggerHandlers.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTriggerHandlers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTriggerHandlers;
    }
}

