using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class OpenDataProject : Form
    {
        public OpenDataProject()
        {
            InitializeComponent();
        }
        private string DeStringize(string s)
        {
            return s;
        }
        private void OpenDataProject_Load(object sender, EventArgs e)
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
            dataGridView1.Columns.Add("Latitude", "Latitude");
            dataGridView1.Columns.Add("Longitude", "Longitude");
            //dodaj try catch
            WebClient client = new WebClient();
            client.DownloadFile("http://opendata.mpn.gov.rs/get.php?dataset=skole&lang=sr&term=csv", "data.csv");
            StreamReader sr = new StreamReader("data.csv");
            sr.ReadLine();
            sr.ReadLine();
            sr.ReadLine();
            while (!sr.EndOfStream)
            {
                string skola=sr.ReadLine();

                
            }
        }
    }
}
