using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class OpenDataProject_Loader : Form
    {
        public OpenDataProject_Loader()
        {
            InitializeComponent();
        }
        private string DeStringize(string s)
        {if (!string.IsNullOrEmpty(s))
            {
                if (s[0] == '"')
                {
                    return s.Substring(1, s.Length - 2);
                }
                else if (s[s.Length - 1] == '"') { return s.Substring(0, s.Length - 2); }
                else { return s; }
            }
            else return s;
        }
        private void Startup()
        {

            //dataGridView1.Columns.Add("ID", "ID");
            //dataGridView1.Columns.Add("Ime", "Ime");
            //dataGridView1.Columns.Add("Adresa", "Adresa");
            //dataGridView1.Columns.Add("Postanski Broj", "Postanski Broj");
            //dataGridView1.Columns.Add("Mesto", "Mesto");
            //dataGridView1.Columns.Add("Opstina", "Opstina");
            //dataGridView1.Columns.Add("Okrug", "Okrug");
            //dataGridView1.Columns.Add("Skolska Uprava", "Skolska Uprava");
            //dataGridView1.Columns.Add("Sajt", "Sajt");
            //dataGridView1.Columns.Add("Telefon", "Telefon");
            //dataGridView1.Columns.Add("Fax", "Fax");
            //dataGridView1.Columns.Add("Tip Skole", "Tip Skole");
            //dataGridView1.Columns.Add("Broj Odeljenja", "Broj Odeljenja");
            //dataGridView1.Columns.Add("Latitude", "Latitude");
            //dataGridView1.Columns.Add("Longitude", "Longitude");
            try {
                WebClient client = new WebClient();
                client.DownloadFile("http://opendata.mpn.gov.rs/get.php?dataset=skole&lang=sr&term=csv", "data.csv");
                File.Copy("data.csv", "kes.csv",true);
            }
            catch{
                MessageBox.Show("Nije moguce preuzeti najnoviju tabelu.\r\nKoristice se kesirana verzija.");
                File.Copy("kes.csv", "data.csv",true);
            }
            StreamReader sr = new StreamReader("data.csv");
            progressBar1.Maximum = 2000;
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string skola=sr.ReadLine();
                string[] data = skola.Split(',');
                for (int i = 0; i < data.Count(); i++)
                {
                    data[i] = DeStringize(data[i]);
                }
                try {
                    OpenDataProjectCore.Skole.Add(new skola(int.Parse(data[0]), data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10], data[11], int.Parse(data[12]), double.Parse(data[13]), double.Parse(data[14])));
                }
                catch { }
                try
                {
                    OpenDataProjectCore.Skole.Add(new skola(int.Parse(data[0]), data[1], data[2], data[3], data[4], data[5], data[6], data[7], data[8], data[9], data[10], data[11], data[12], data[13], int.Parse(data[14]), double.Parse(data[15]), double.Parse(data[16])));
                }
                catch { }
                progressBar1.PerformStep();
                //string[] row = OpenDataProjectCore.Skole.ElementAt(OpenDataProjectCore.Skole.Count - 1).ToRow();
                //dataGridView1.Rows.Add(row);
            }
        }

        private void OpenDataProject_Load(object sender, EventArgs e)
        {
           
           
        }

        private void OpenDataProject_Loader_Shown(object sender, EventArgs e)
        {
            Startup();
            progressBar1.Value = progressBar1.Maximum;
        }
    }
}
