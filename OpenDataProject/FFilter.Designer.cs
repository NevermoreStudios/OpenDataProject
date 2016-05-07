namespace OpenDataProject
{
    partial class FFilter
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Filt = new System.Windows.Forms.Button();
            this.Query = new System.Windows.Forms.Button();
            this.Qname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(495, 261);
            this.dataGridView1.TabIndex = 0;
            // 
            // Filt
            // 
            this.Filt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Filt.Location = new System.Drawing.Point(12, 226);
            this.Filt.Name = "Filt";
            this.Filt.Size = new System.Drawing.Size(125, 23);
            this.Filt.TabIndex = 1;
            this.Filt.Text = "(filter)";
            this.Filt.UseVisualStyleBackColor = true;
            this.Filt.Click += new System.EventHandler(this.Filt_Click);
            // 
            // Query
            // 
            this.Query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Query.Location = new System.Drawing.Point(274, 226);
            this.Query.Name = "Query";
            this.Query.Size = new System.Drawing.Size(150, 23);
            this.Query.TabIndex = 2;
            this.Query.Text = "(add as query)";
            this.Query.UseVisualStyleBackColor = true;
            this.Query.Click += new System.EventHandler(this.Query_Click);
            // 
            // Qname
            // 
            this.Qname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Qname.Location = new System.Drawing.Point(143, 226);
            this.Qname.Name = "Qname";
            this.Qname.Size = new System.Drawing.Size(125, 20);
            this.Qname.TabIndex = 3;
            // 
            // FFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 261);
            this.Controls.Add(this.Qname);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.Filt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FFilter";
            this.Text = "(filter)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Filt;
        private System.Windows.Forms.Button Query;
        private System.Windows.Forms.TextBox Qname;
    }
}