using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

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
                client.DownloadFile("http://opendata.mpn.gov.rs/get.php?dataset=skole&lang=sr&term=json", "data.json");
                File.Copy("data.json", "kes.json",true);
            }
            catch{
                MessageBox.Show("Nije moguce preuzeti najnoviju tabelu.\r\nKoristice se kesirana verzija.");
                File.Copy("kes.json", "data.json",true);
            }
            StreamReader sr = new StreamReader("data.json");
            string json=sr.ReadToEnd();
            Core.Skole = JsonConvert.DeserializeObject<List<Skola>>(json);
        }


        private void OpenDataProject_Loader_Shown(object sender, EventArgs e)
        {
            Startup();
            Filter.Show();
            Sort.Show();
            Ptable.Show();
            Pchart.Show();
            Map.Show();
            View.Show();
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
            Map Map = new Map("All");
            Map.Show();
            
        }

        private void View_Click(object sender, EventArgs e)
        {
            //TO DO: Implement
        }
    }
}
