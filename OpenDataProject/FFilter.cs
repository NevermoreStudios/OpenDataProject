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
    public partial class FFilter : Form
    {
        public FFilter()
        {
            InitializeComponent();
        }

        private void FFilter_Load(object sender, EventArgs e)
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
        }

        private void Query_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Qname.Text)) { MessageBox.Show("Query mora imati ime"); }
            else
            {
                List<Skola> result = new List<Skola>();
                try
                {
                    result = FilterS();
                    try
                    {
                        Core.Queries.Add(Qname.Text, result);
                        MessageBox.Show("Query Added");
                    }
                    catch
                    {
                        if (MessageBox.Show("Query vec postoji, overide","Error", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            Core.Queries[Qname.Text] = result;
                        }

                    }
                }
                catch
                {
                    MessageBox.Show("Filter was not in corect format");
                }
                
            }
        }

        private List<Skola> FilterS()
        {
            List<Skola> result = new List<Skola>();
            foreach (Skola s in Core.Skole)
            {
                bool isit;
                string[] srow = s.ToRow();
                foreach (DataGridViewRow R in dataGridView1.Rows)
                {
                    if(R.Index!=dataGridView1.RowCount-1){ 
                    isit = true;
                    foreach (DataGridViewCell C in R.Cells)
                    {
                        int col = C.ColumnIndex;
                        string str = (string)C.Value;
                        if (!string.IsNullOrWhiteSpace(str))
                        {
                                if (col==3 || col==12) {
                                    int comp;
                                    int.TryParse(srow[col], out comp);
                                    if (!IntComp(comp,str))
                                    {
                                        isit = false;
                                        goto row;
                                    }

                                }
                                else
                                {
                                    if(srow[col] != str)
                                    {
                                        isit = false;
                                        goto row;
                                    }
                                }
                        }
                    }
                    if (isit)
                    {
                        result.Add(s);
                        goto end;
                    }
                    row:;
                }
                }
                end:;
            }
            return result;
        }

        private bool IntComp(int comp, string str)
        {
            string[] subs = str.Split(',');
            bool isit = true;
            int nr;
            foreach (string s in subs)
            {
                if (s[0] == '>')
                {
                    if (s[1] == '=')
                    {
                        nr = int.Parse(s.Substring(2));
                        if (!(comp>=nr)) {
                            isit = false;
                            goto End;
                        }
                    }
                    else
                    {
                        nr = int.Parse(s.Substring(1));
                            if (!(comp > nr))
                        {
                            isit = false;
                            goto End;
                        }
                    }
                }
                else if (s[0] == '<')
                {
                    if (s[1] == '=')
                    {
                        nr = int.Parse(s.Substring(2));
                        if (!(comp <= nr))
                        {
                            isit = false;
                            goto End;
                        }
                    }
                    else
                    {
                        nr = int.Parse(s.Substring(1));
                        if (!(comp < nr))
                        {
                            isit = false;
                            goto End;
                        }
                    }
                }
                else if (s[0] == '=')
                {
                    if (s[1] == '>')
                    {
                        nr = int.Parse(s.Substring(2));
                        if(!(comp >= nr)) {
                            isit = false;
                            goto End;
                        }
                    }
                    else if (s[1] == '<')
                    {
                        nr = int.Parse(s.Substring(2));
                        if (!(comp >= nr))
                        {
                            isit = false;
                            goto End;
                        }
                    }
                    else
                    {
                        nr = int.Parse(s.Substring(1));
                        if (!(comp == nr))
                        {
                            isit = false;
                            goto End;
                        }
                    }
                }
                else {
                    if (s[s.Length-1] == '>')
                    {
                        if (s[s.Length-2] == '=')
                        {
                            nr = int.Parse(s.Substring(0,s.Length-2));
                            if (!(comp <= nr))
                            {
                                isit = false;
                                goto End;
                            }
                        }
                        else
                        {
                            nr = int.Parse(s.Substring(0,s.Length-1));
                            if (!(comp < nr))
                            {
                                isit = false;
                                goto End;
                            }
                        }
                    }
                    else if (s[s.Length-1] == '<')
                    {
                        if (s[s.Length-2] == '=')
                        {
                            nr = int.Parse(s.Substring(0,s.Length-2));
                            if (!(comp >= nr))
                            {
                                isit = false;
                                goto End;
                            }
                        }
                        else
                        {
                            nr = int.Parse(s.Substring(0,s.Length-1));
                            if (!(comp > nr))
                            {
                                isit = false;
                                goto End;
                            }
                        }
                    }
                    else if (s[s.Length-1] == '=')
                    {
                        if (s[s.Length-2] == '>')
                        {
                            nr = int.Parse(s.Substring(0,s.Length-2));
                            if (!(comp <= nr))
                            {
                                isit = false;
                                goto End;
                            }
                        }
                        else if (s[s.Length-2] == '<')
                        {
                            nr = int.Parse(s.Substring(0, s.Length - 2));
                            if (!(comp >= nr))
                            {
                                isit = false;
                                goto End;
                            }
                        }
                        else
                        {
                            nr = int.Parse(s.Substring(0, s.Length - 1));
                            if (!(comp == nr))
                            {
                                isit = false;
                                goto End;
                            }
                        }
                    }
                }

            }
            End:;return isit;
        }

        private void Filt_Click(object sender, EventArgs e)
        {
            try
            {
                Viewer VW = new Viewer(FilterS());
                VW.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Filter was not in corect format");
            }
            
        }
    }
}
