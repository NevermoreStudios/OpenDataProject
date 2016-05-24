namespace OpenDataProject
{
    partial class About
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
            this.Title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Desc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(13, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(29, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "(title)";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(13, 38);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(47, 13);
            this.Version.TabIndex = 1;
            this.Version.Text = "(version)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "(ok)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Desc
            // 
            this.Desc.Enabled = false;
            this.Desc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Desc.HideSelection = false;
            this.Desc.Location = new System.Drawing.Point(16, 64);
            this.Desc.Multiline = true;
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Size = new System.Drawing.Size(335, 151);
            this.Desc.TabIndex = 4;
            this.Desc.TabStop = false;
            this.Desc.Text = "(appdesc)";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 279);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "About";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(about)";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Version;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Desc;
    }
}