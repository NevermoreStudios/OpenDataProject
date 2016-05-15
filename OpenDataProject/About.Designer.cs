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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.Title = new System.Windows.Forms.Label();
            this.Version = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(13, 13);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(92, 13);
            this.Title.TabIndex = 0;
            this.Title.Text = "Open data project";
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(13, 38);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(72, 13);
            this.Version.TabIndex = 1;
            this.Version.Text = "Version: 1.0.0";
            // 
            // Desc
            // 
            this.Desc.AutoSize = true;
            this.Desc.Location = new System.Drawing.Point(13, 65);
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(352, 156);
            this.Desc.TabIndex = 2;
            this.Desc.Text = resources.GetString("Desc.Text");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 25);
            this.button1.TabIndex = 3;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Desc);
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
        private System.Windows.Forms.Label Desc;
        private System.Windows.Forms.Button button1;
    }
}