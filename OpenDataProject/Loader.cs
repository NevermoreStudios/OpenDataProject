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
            progressBar1.PerformStep();
            try {
                WebClient client = new WebClient();
                client.DownloadFile("http://opendata.mpn.gov.rs/get.php?dataset=skole&lang=sr&term=json", "data.json");
                File.Copy("data.json", "kes.json",true);
            }
            catch{
                MessageBox.Show("Nije moguce preuzeti najnoviju tabelu.\r\nKoristice se kesirana verzija.");
                File.Copy("kes.json", "data.json",true);
            }
            progressBar1.PerformStep();
            StreamReader sr = new StreamReader("data.json");
            string json=sr.ReadToEnd();
            progressBar1.PerformStep();
            Core.Skole = JsonConvert.DeserializeObject<List<Skola>>(json);
            progressBar1.PerformStep();
        }


        private void OpenDataProject_Loader_Shown(object sender, EventArgs e)
        {
            Startup();
            Filter.Show();
            Sort.Show();
            Ptable.Show();
            Map.Show();
            View.Show();
            progressBar1.Value = 100;
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

        private void Map_Click(object sender, EventArgs e)
        {
            QueryPicker Q = new QueryPicker("Map");
            Q.Show();
            
        }

        private void View_Click(object sender, EventArgs e)
        {
            QueryPicker Q = new QueryPicker("Viewer");
            Q.Show();

        }
    }
}
