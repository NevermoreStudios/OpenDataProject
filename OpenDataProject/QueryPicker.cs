using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class QueryPicker : Form
    {
        string form;
        Vocab vocab;

        public QueryPicker(string form)
        {
            this.form = form;
            InitializeComponent();
            RefreshVocab();
        }

        private void QueryPicker_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(vocab.all);
            comboBox1.Items.AddRange(Core.Queries.Keys.ToArray());
            comboBox1.SelectedIndex = 0;
        }

        private void RefreshVocab()
        {
            vocab = Core.GetVocab();
            Text = vocab.queryPickerTitle;
            Pick.Text = vocab.use;
        }

        private void Pick_Click(object sender, EventArgs e)
        {
            GetForm().Show();
            Close();
        }

        private Form GetForm()
        {
            List<Skola> param = Core.GetFilter(comboBox1.SelectedItem.ToString());
            switch (form)
            {
                case "Map": return new Map(param);
                case "Sort": return new Sort(param);
                case "Viewer": return new Viewer(param);
                case "Ptable": return new Chart(param);
//              case "Pchart": return new Pie(param);
                default: return null; // Ako dovde stignemo mi smo debili
            }
        }
    }
}
