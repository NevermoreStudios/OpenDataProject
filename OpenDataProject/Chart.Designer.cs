namespace OpenDataProject
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Options1 = new System.Windows.Forms.ComboBox();
            this.Options2 = new System.Windows.Forms.ComboBox();
            this.View = new System.Windows.Forms.Button();
            this.Chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // Options1
            // 
            this.Options1.FormattingEnabled = true;
            this.Options1.Location = new System.Drawing.Point(12, 10);
            this.Options1.Name = "Options1";
            this.Options1.Size = new System.Drawing.Size(121, 21);
            this.Options1.TabIndex = 0;
            // 
            // Options2
            // 
            this.Options2.FormattingEnabled = true;
            this.Options2.Location = new System.Drawing.Point(139, 10);
            this.Options2.Name = "Options2";
            this.Options2.Size = new System.Drawing.Size(121, 21);
            this.Options2.TabIndex = 1;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(269, 10);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(75, 23);
            this.View.TabIndex = 2;
            this.View.Text = "(view)";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart1.ChartAreas.Add(chartArea1);
            this.Chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.Chart1.Legends.Add(legend1);
            this.Chart1.Location = new System.Drawing.Point(0, 0);
            this.Chart1.Name = "Chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.Chart1.Series.Add(series1);
            this.Chart1.Size = new System.Drawing.Size(357, 330);
            this.Chart1.TabIndex = 3;
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 330);
            this.Controls.Add(this.View);
            this.Controls.Add(this.Options2);
            this.Controls.Add(this.Options1);
            this.Controls.Add(this.Chart1);
            this.Name = "Chart";
            this.Text = "(chart)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Options1;
        private System.Windows.Forms.ComboBox Options2;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart1;
    }
}