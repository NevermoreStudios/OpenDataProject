using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class Viewer : Form
    {
        List<Skola> Data;
        private Vocab vocab;

        public Viewer(List<Skola> Data)
        {
            this.Data = Data;
            InitializeComponent();
            RefreshVocab();
        }

        private void RefreshVocab()
        {
            vocab = Core.GetVocab();
            Text = vocab.viewer;
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            foreach (string s in vocab.GetRow()) dataGridView1.Columns.Add(s, s);
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            foreach (Skola s in Data) dataGridView1.Rows.Add(s.ToRow());
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Details det = new Details(Data.ElementAt(e.RowIndex));
                det.ShowDialog();
            }
            catch { /* Stuff happens */ }
        }
    }
}
