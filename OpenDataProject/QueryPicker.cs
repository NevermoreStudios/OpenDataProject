using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class QueryPicker : Form
    {
        string form;
        public QueryPicker(string form)
        {
            this.form = form;
            InitializeComponent();
        }

        private void QueryPicker_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("All");
            comboBox1.Items.AddRange(Core.Queries.Keys.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void Pick_Click(object sender, EventArgs e)
        {
            switch (form)
            {
                case "Map": { Map Map = new Map(Core.GetFilter(comboBox1.SelectedItem.ToString())); Map.Show(); this.Close();
                        break; }
                case "Sort": { Sort Sort=new Sort(Core.GetFilter(comboBox1.SelectedItem.ToString())); Sort.Show(); this.Close();
                        break; }
                case "Viewer": { Viewer Viewer = new Viewer(Core.GetFilter(comboBox1.SelectedItem.ToString())); Viewer.Show(); this.Close();
                        break; }
                case "Ptable": { Chart Ptable = new Chart(Core.GetFilter(comboBox1.SelectedItem.ToString())); Ptable.Show(); this.Close();
                        break; }
                case "Pchart":
                    {
                        // Ptable = new Pie(Core.GetFilter(comboBox1.SelectedItem.ToString())); Ptable.Show(); this.Close();
                        break;
                    }
            }
        }
    }
}
