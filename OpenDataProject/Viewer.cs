using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class Viewer : Form
    {
        List<Skola> Data;
        public Viewer(List<Skola> Data)
        {
            this.Data = Data;
            InitializeComponent();
        }

        private void Viewer_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID");
            dataGridView1.Columns.Add("Ime", "Ime");
            dataGridView1.Columns.Add("Adresa", "Adresa");
            dataGridView1.Columns.Add("Postanski Broj", "Postanski Broj");
            dataGridView1.Columns.Add("Mesto", "Mesto");
            dataGridView1.Columns.Add("Opstina", "Opstina");
            dataGridView1.Columns.Add("Okrug", "Okrug");
            dataGridView1.Columns.Add("Skolska Uprava", "Skolska Uprava");
            dataGridView1.Columns.Add("Sajt", "Sajt");
            dataGridView1.Columns.Add("Telefon", "Telefon");
            dataGridView1.Columns.Add("Fax", "Fax");
            dataGridView1.Columns.Add("Tip Skole", "Tip Skole");
            dataGridView1.Columns.Add("Broj Odeljenja", "Broj Odeljenja");
            dataGridView1.Columns.Add("Gps", "Gps");
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (Skola s in Data)
            {
                dataGridView1.Rows.Add(s.ToRow());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Details det = new Details(Data.ElementAt(e.RowIndex));
                det.ShowDialog();
            }
            catch { }
        }
    }
}
