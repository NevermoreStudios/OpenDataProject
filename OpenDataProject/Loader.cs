using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace OpenDataProject
{
    public partial class Loader : Form
    {
        private Vocab vocab;

        public Loader() { InitializeComponent(); }
        
        private void Loader_Load(object sender, EventArgs e)
        {
            Splash Splash = new Splash();
            Splash.Show();
            LoadVocab();
            RefreshVocab();
            DownloadData();
            LoadData();
            LoadLanguageChanger();
            Splash.Close();
            Splash.Dispose();
        }

        private void LoadVocab()
        {
            try
            {
                StreamReader sr = new StreamReader("vocab.json");
                Core.Dict = JsonConvert.DeserializeObject<Dictionary<string, Vocab>>(sr.ReadToEnd());
                sr.Dispose();
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                MessageBox.Show("An error occurred while loading dictionary data.");
            }
        }

        private void RefreshVocab()
        {
            vocab = Core.GetVocab();
            Text = vocab.loaderTitle;
            View.Text = vocab.viewData;
            Filter.Text = vocab.filter;
            Sort.Text = vocab.sort;
            Ptable.Text = vocab.chart;
            Map.Text = vocab.map;
            ChangeLanguage.Text = vocab.changeLanguage;
            OtherGroup.Text = vocab.other;
            LanguageGroup.Text = vocab.language;
            Help.Text = vocab.help;
            About.Text = vocab.about;
            ToolsGroup.Text = vocab.tools;
        }

        private void DownloadData()
        {
            try
            {
                WebClient client = new WebClient();
                client.DownloadFile("http://opendata.mpn.gov.rs/get.php?dataset=skole&lang=sr&term=json", "data.json");
                File.Copy("data.json", "kes.json", true);
            }
            catch
            {
                MessageBox.Show(vocab.Error("downloadData"));
                File.Copy("kes.json", "data.json", true);
            }
        }

        private void LoadData()
        {
            try
            {
                StreamReader sr = new StreamReader("data.json");
                Core.Skole = JsonConvert.DeserializeObject<List<Skola>>(sr.ReadToEnd());
                sr.Dispose();
                sr.Close();
            }
            catch(IOException)
            {
                MessageBox.Show(vocab.Error("loadingData"));
                Close();
            }
        }

        private void LoadLanguageChanger()
        {
            ChangeLanguageSelect.Items.AddRange(Core.Dict.Keys.ToArray());
            ChangeLanguageSelect.SelectedIndex = 0;
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            FFilter FFilter = new FFilter();
            FFilter.Show();
        }

        private void ToolBaseClick(string tool)
        {
            QueryPicker Q = new QueryPicker(tool);
            Q.Show();
        }

        private void Sort_Click     (object a, EventArgs b) { ToolBaseClick("Sort");    }
        private void Ptable_Click   (object a, EventArgs b) { ToolBaseClick("Ptable");  }
        private void Map_Click      (object a, EventArgs b) { ToolBaseClick("Map");     }
        private void View_Click     (object a, EventArgs b) { ToolBaseClick("Viewer");  }
        
        private void ChangeLanguage_Click(object sender, EventArgs e)
        {
            int index = ChangeLanguageSelect.SelectedIndex;
            Core.CurrentLanguage = (string)ChangeLanguageSelect.Items[index];
            RefreshVocab();
        }

        private void Help_Click(object sender, EventArgs e)
        {
            // TO DO: Implement
        }

        private void About_Click(object sender, EventArgs e)
        {
            About Ab = new About();
            Ab.ShowDialog();
        }
    }
}
