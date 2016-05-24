using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class Sort : Form
    {
        private List<Skola> Data;
        private Vocab vocab;

        public Sort(List<Skola> Data)
        {
            this.Data = Data;
            InitializeComponent();
            RefreshVocab();
        }

        private void RefreshVocab()
        {
            vocab = Core.GetVocab();
            Text = vocab.sort;
            radioButton1.Text = vocab.increase;
            radioButton2.Text = vocab.decrease;
            button1.Text = vocab.add;
            button2.Text = vocab.sort;
        }
        
        private int Compare(Skola a, Skola b)
        {
            int n = int.Parse(listBox1.Items.Count.ToString()), p, opada, u1 = 0, u2 = 0;
            string us, k;
            string[] array = vocab.GetRow();
            for (int i = 0; i < n; ++i)
            {
                us = listBox1.Items[i].ToString();
                p = us.LastIndexOf(" ");
                k = us.Substring(0, p);
                if (us[p + 1] == vocab.increase[0]) opada = -1;
                else opada = 1;
                for (int j = 0; j < 13; ++j) if(k == array[j])
                {
                    if (j == 0 || j == 3 || j == 12)
                    {
                        try
                        {
                            u1 = int.Parse(GetCorrectAttribute(a, j));
                            u2 = int.Parse(GetCorrectAttribute(b, j));
                        }
                        catch { }
                    }
                    else
                    {
                        u1 = string.Compare(GetCorrectAttribute(a, j), GetCorrectAttribute(b, j));
                        u2 = 0;
                    }
                    break;
                }
                if (u1 > u2) return -1 * opada;
                else if (u1 < u2) return opada;
            }
            return 0;
        }

        private string GetCorrectAttribute(Skola a, int j)
        {
            switch(j)
            {
                case 0: return a.id;
                case 1: return a.naziv;
                case 2: return a.adresa;
                case 3: return a.pbroj;
                case 4: return a.mesto;
                case 5: return a.opstina;
                case 6: return a.okrug;
                case 7: return a.suprava;
                case 8: return a.www;
                case 9: return a.tel;
                case 10: return a.fax;
                case 11: return a.vrsta;
                case 12: return a.odeljenja;
                case 13: return a.gps;
                default: return "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text + " " + (radioButton1.Checked ? vocab.increase : vocab.decrease));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Data.Sort(Compare);
            Viewer Viewer = new Viewer(Data);
            Viewer.ShowDialog();
            listBox1.Items.Clear();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            foreach (string s in vocab.GetRow()) comboBox1.Items.Add(s);
        }
    }
}
