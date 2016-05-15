namespace OpenDataProject
{
    partial class Loader
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
            this.Filter = new System.Windows.Forms.Button();
            this.Sort = new System.Windows.Forms.Button();
            this.Ptable = new System.Windows.Forms.Button();
            this.Map = new System.Windows.Forms.Button();
            this.View = new System.Windows.Forms.Button();
            this.ChangeLanguage = new System.Windows.Forms.Button();
            this.ToolsGroup = new System.Windows.Forms.GroupBox();
            this.LanguageGroup = new System.Windows.Forms.GroupBox();
            this.ChangeLanguageSelect = new System.Windows.Forms.ComboBox();
            this.OtherGroup = new System.Windows.Forms.GroupBox();
            this.About = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.ToolsGroup.SuspendLayout();
            this.LanguageGroup.SuspendLayout();
            this.OtherGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(6, 48);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(110, 23);
            this.Filter.TabIndex = 1;
            this.Filter.Text = "(filter)";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Sort
            // 
            this.Sort.Location = new System.Drawing.Point(122, 19);
            this.Sort.Name = "Sort";
            this.Sort.Size = new System.Drawing.Size(110, 23);
            this.Sort.TabIndex = 2;
            this.Sort.Text = "(sort)";
            this.Sort.UseVisualStyleBackColor = true;
            this.Sort.Click += new System.EventHandler(this.Sort_Click);
            // 
            // Ptable
            // 
            this.Ptable.Location = new System.Drawing.Point(122, 48);
            this.Ptable.Name = "Ptable";
            this.Ptable.Size = new System.Drawing.Size(110, 23);
            this.Ptable.TabIndex = 3;
            this.Ptable.Text = "(chart)";
            this.Ptable.UseVisualStyleBackColor = true;
            this.Ptable.Click += new System.EventHandler(this.Ptable_Click);
            // 
            // Map
            // 
            this.Map.Location = new System.Drawing.Point(122, 77);
            this.Map.Name = "Map";
            this.Map.Size = new System.Drawing.Size(110, 23);
            this.Map.TabIndex = 5;
            this.Map.Text = "(map)";
            this.Map.UseVisualStyleBackColor = true;
            this.Map.Click += new System.EventHandler(this.Map_Click);
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(6, 19);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(110, 23);
            this.View.TabIndex = 6;
            this.View.Text = "(viewData)";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // ChangeLanguage
            // 
            this.ChangeLanguage.Location = new System.Drawing.Point(7, 19);
            this.ChangeLanguage.Name = "ChangeLanguage";
            this.ChangeLanguage.Size = new System.Drawing.Size(110, 23);
            this.ChangeLanguage.TabIndex = 7;
            this.ChangeLanguage.Text = "(changeLanguage)";
            this.ChangeLanguage.UseVisualStyleBackColor = true;
            this.ChangeLanguage.Click += new System.EventHandler(this.ChangeLanguage_Click);
            // 
            // ToolsGroup
            // 
            this.ToolsGroup.Controls.Add(this.View);
            this.ToolsGroup.Controls.Add(this.Map);
            this.ToolsGroup.Controls.Add(this.Sort);
            this.ToolsGroup.Controls.Add(this.Filter);
            this.ToolsGroup.Controls.Add(this.Ptable);
            this.ToolsGroup.Location = new System.Drawing.Point(12, 12);
            this.ToolsGroup.Name = "ToolsGroup";
            this.ToolsGroup.Size = new System.Drawing.Size(242, 112);
            this.ToolsGroup.TabIndex = 8;
            this.ToolsGroup.TabStop = false;
            this.ToolsGroup.Text = "(tools)";
            // 
            // LanguageGroup
            // 
            this.LanguageGroup.Controls.Add(this.ChangeLanguageSelect);
            this.LanguageGroup.Controls.Add(this.ChangeLanguage);
            this.LanguageGroup.Location = new System.Drawing.Point(260, 12);
            this.LanguageGroup.Name = "LanguageGroup";
            this.LanguageGroup.Size = new System.Drawing.Size(123, 80);
            this.LanguageGroup.TabIndex = 9;
            this.LanguageGroup.TabStop = false;
            this.LanguageGroup.Text = "(language)";
            // 
            // ChangeLanguageSelect
            // 
            this.ChangeLanguageSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChangeLanguageSelect.FormattingEnabled = true;
            this.ChangeLanguageSelect.Location = new System.Drawing.Point(6, 48);
            this.ChangeLanguageSelect.Name = "ChangeLanguageSelect";
            this.ChangeLanguageSelect.Size = new System.Drawing.Size(110, 21);
            this.ChangeLanguageSelect.TabIndex = 8;
            // 
            // OtherGroup
            // 
            this.OtherGroup.Controls.Add(this.About);
            this.OtherGroup.Controls.Add(this.Help);
            this.OtherGroup.Location = new System.Drawing.Point(262, 98);
            this.OtherGroup.Name = "OtherGroup";
            this.OtherGroup.Size = new System.Drawing.Size(121, 84);
            this.OtherGroup.TabIndex = 10;
            this.OtherGroup.TabStop = false;
            this.OtherGroup.Text = "(other)";
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(6, 48);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(108, 23);
            this.About.TabIndex = 1;
            this.About.Text = "(about)";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(6, 19);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(109, 23);
            this.Help.TabIndex = 0;
            this.Help.Text = "(help)";
            this.Help.UseVisualStyleBackColor = true;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Loader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 194);
            this.Controls.Add(this.OtherGroup);
            this.Controls.Add(this.LanguageGroup);
            this.Controls.Add(this.ToolsGroup);
            this.MaximizeBox = false;
            this.Name = "Loader";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "(loaderTitle)";
            this.Load += new System.EventHandler(this.Loader_Load);
            this.ToolsGroup.ResumeLayout(false);
            this.LanguageGroup.ResumeLayout(false);
            this.OtherGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Button Sort;
        private System.Windows.Forms.Button Ptable;
        private System.Windows.Forms.Button Map;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Button ChangeLanguage;
        private System.Windows.Forms.GroupBox ToolsGroup;
        private System.Windows.Forms.GroupBox LanguageGroup;
        private System.Windows.Forms.ComboBox ChangeLanguageSelect;
        private System.Windows.Forms.GroupBox OtherGroup;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button About;
    }
}

