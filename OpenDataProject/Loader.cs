using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class Loader : Form
    {
        public Loader() { InitializeComponent(); }
        
        // TO DO: Parser
        private string DeStringize(string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                if (s[0] == '"') return s.Substring(1, s.Length - 2);
                else if (s[s.Length - 1] == '"') { return s.Substring(0, s.Length - 2); }
                else { return s; }
            }
            else return s;
        }

        // TO DO: Parser
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
            //TO DO JASON
            //StreamReader sr = new StreamReader("data.csv");
            //progressBar1.Maximum = 2000;
            //sr.ReadLine();
            //sr.ReadLine();
            //sr.ReadLine();
            //while (!sr.EndOfStream)
            //{
            //    string skola = sr.ReadLine();
            //    string[] data = skola.Split(',');
            //    if (data.Length == 15)  Core.Skole.Add(new Skola(int.Parse(DeStringize(data[0])), DeStringize(data[1]), DeStringize(data[2]), DeStringize(data[3]), DeStringize(data[4]), DeStringize(data[5]), DeStringize(data[6]), DeStringize(data[7]), DeStringize(data[8]), DeStringize(data[9]), DeStringize(data[10]), DeStringize(data[11]), int.Parse(DeStringize(data[12])), double.Parse(DeStringize(data[13])), double.Parse(DeStringize(data[14]))));
            //    else if(data.Length==17)Core.Skole.Add(new Skola(int.Parse(DeStringize(data[0])), DeStringize(data[1]), DeStringize(data[2]), DeStringize(data[3]), DeStringize(data[4]), DeStringize(data[5]), DeStringize(data[6]), DeStringize(data[7]), DeStringize(data[8]), DeStringize(data[9]), DeStringize(data[10]), DeStringize(data[11]), DeStringize(data[12]), DeStringize(data[13]), int.Parse(DeStringize(data[14])), double.Parse(DeStringize(data[15])), double.Parse(DeStringize(data[16]))));
            //    else Core.Skole.Add(new Skola(int.Parse(DeStringize(data[0])), DeStringize(data[1]), DeStringize(data[2]), DeStringize(data[3]), DeStringize(data[4]), DeStringize(data[5]), DeStringize(data[6]), DeStringize(data[7]), DeStringize(data[8]), DeStringize(data[9]), DeStringize(data[10]), DeStringize(data[11]), int.Parse(DeStringize(data[12])), double.Parse(DeStringize(data[13])), double.Parse(DeStringize(data[13]))));
            //    progressBar1.PerformStep();
            //    //string[] row = OpenDataProjectCore.Skole.ElementAt(OpenDataProjectCore.Skole.Count - 1).ToRow();
            //    //dataGridView1.Rows.Add(row);
            //}
        }


        private void OpenDataProject_Loader_Shown(object sender, EventArgs e)
        {
            Startup();
            progressBar1.Value = progressBar1.Maximum;
            Filter.Show();
            Sort.Show();
            Ptable.Show();
            Pchart.Show();
            Map.Show();
        }

        private void OpenDataProject_Loader_Load(object sender, EventArgs e)
        {
            // TO DO: Implement
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            // TO DO: Implement
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            // TO DO: Implement
        }

        private void Ptable_Click(object sender, EventArgs e)
        {
            // TO DO: Implement
        }

        private void Pchart_Click(object sender, EventArgs e)
        {
            // TO DO: Implement
        }

        private void Map_Click(object sender, EventArgs e)
        {
            Map Map = new Map();
            Map.Show();
            
        }
    }
}
