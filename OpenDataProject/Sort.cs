using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;
using OpenDataProject;

namespace OpenDataProject
{
    public partial class Sort : Form
    {

        public Sort(List<Skola> con)
        {
            this.Data = con;
            InitializeComponent();
        }
        public List<Skola> Data;
        public int Compare(Skola a, Skola b)
        {
            int n = int.Parse(listBox1.Items.Count.ToString()), p;
            string us, k;
            int opada;
            for (int i = 0; i < n; ++i)
            {
                us = listBox1.Items[i].ToString();
                p = us.IndexOf(" ");
                k = us.Substring(0,p);
                if (us[p + 1] == 'R') opada = -1;
                else opada = 1;
                if (k == "ID")
                {
                    int ai, bi;
                    int.TryParse(a.id,out ai);
                    int.TryParse(b.id,out bi);
                    if (ai < bi) return opada;
                    if (ai > bi) return -1*opada;
                }
                else if (k == "Ime")
                {
                    if (String.Compare(a.naziv, b.naziv) > 0) return -1 * opada;
                    if (String.Compare(a.naziv, b.naziv) < 0) return opada;
                }
                else if (k == "Adresa")
                {
                    if (String.Compare(a.adresa, b.adresa) > 0) return -1 * opada;
                    if (String.Compare(a.adresa, b.adresa) < 0) return opada;
                }
                else if (k == "Postanski")
                {
                    if (us[15] == 'O') opada = 1;
                    else opada = -1;
                    int ai, bi;
                    int.TryParse(a.pbroj, out ai);
                    int.TryParse(b.pbroj, out bi);
                    if (ai < bi) return opada;
                    if (ai > bi) return -1 * opada;
                }
                else if (k == "Mesto")
                {
                    if (String.Compare(a.mesto, b.mesto) > 0) return -1 * opada;
                    if (String.Compare(a.mesto, b.mesto) < 0) return opada;
                }
                else if (k == "Okrug")
                {
                    if (String.Compare(a.okrug, b.okrug) > 0) return -1 * opada;
                    if (String.Compare(a.okrug, b.okrug) < 0) return opada;
                }
                else if (k == "Opstina")
                {
                    if (String.Compare(a.opstina, b.opstina) > 0) return -1 * opada;
                    if (String.Compare(a.opstina, b.opstina) < 0) return opada;
                }
                else if (k == "Skolska")
                {
                    if (us[15] == 'O') opada = 1;
                    else opada = -1;
                    if (String.Compare(a.suprava, b.suprava) > 0) return -1 * opada;
                    if (String.Compare(a.suprava, b.suprava) < 0) return opada;
                }
                else if (k == "Sajt")
                {
                    if (String.Compare(a.www, b.www) > 0) return -1 * opada;
                    if (String.Compare(a.www, b.www) < 0) return opada;
                }
                else if (k == "Telefon")
                {
                    if (String.Compare(a.tel, b.tel) < 0) return opada;
                    if (String.Compare(a.tel, b.tel) > 0) return -1 * opada;
                }
                else if (k == "Fax")
                {
                    if(String.Compare(a.fax, b.fax) > 0) return -1 * opada;
                    if (String.Compare(a.fax, b.fax) < 0) return opada;
                }
                else if (k == "Tip")
                {
                    if (us[10] == 'O') opada = 1;
                    else opada = -1;
                    if (String.Compare(a.vrsta, b.vrsta) > 0) return -1 * opada;
                    if (String.Compare(a.vrsta, b.vrsta) < 0) return opada;
                }
                else if (k == "Broj")
                {
                    if (us[15] == 'O') opada = 1;
                    else opada = -1;
                    int ai, bi;
                    int.TryParse(a.odeljenja, out ai);
                    int.TryParse(b.odeljenja, out bi);
                    if (ai < bi) return opada;
                    if (ai > bi) return -1 * opada;
                }
            }
            return 0;
        }


       

        private void button1_Click(object sender, EventArgs e)
        {
            string prikaz = comboBox1.Text;
            if (radioButton1.Checked) prikaz += " Rastuće";
            else prikaz += " Opadajuće";
            listBox1.Items.Add(prikaz);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Compare(Data[0], Data[1]);
            Data.Sort(Compare);
            Viewer Viewer=new Viewer(Data);
            Viewer.ShowDialog();
            listBox1.Items.Clear();
        }

        private void Sort_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ime");
            comboBox1.Items.Add("ID");
            comboBox1.Items.Add("Adresa");
            comboBox1.Items.Add("Postanski broj");
            comboBox1.Items.Add("Mesto");
            comboBox1.Items.Add("Opstina");
            comboBox1.Items.Add("Okrug");
            comboBox1.Items.Add("Skolska uprava");
            comboBox1.Items.Add("Sajt");
            comboBox1.Items.Add("Telefon");
            comboBox1.Items.Add("Fax");
            comboBox1.Items.Add("Tip skole");
            comboBox1.Items.Add("Broj odeljenja");
        }
    }
}
