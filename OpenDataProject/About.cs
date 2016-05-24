using System;
using System.Reflection;
using System.Windows.Forms;

namespace OpenDataProject
{
    public partial class About : Form
    {
        private Vocab vocab;

        public About()
        {
            InitializeComponent();
        }

        private void RefreshVocab()
        {
            vocab = Core.GetVocab();
            AssemblyName name = Assembly.GetEntryAssembly().GetName();
            button1.Text = vocab.ok;
            Title.Text = name.Name;
            Version.Text = vocab.version + ": " + name.Version.ToString();
            Desc.Text = vocab.appdesc + "\r\n" + vocab.teammembers +
                ":\r\n- " + vocab.mentor + " - Filip Marić (" + vocab.professor + " " + vocab.at + " " + vocab.mg + " " + vocab.at + " " + vocab.rg +
                ")\r\n- Luka Simić (1. " + vocab.grade + " " + vocab.at + " " + vocab.rg +
                ")\r\n- Lazar Premović (1. " + vocab.grade + " " + vocab.at + " " + vocab.rg +
                ")\r\n- Mateja Brnabić (1. " + vocab.grade + " " + vocab.at + " " + vocab.rg +
                ")\r\n- Katarina Krivokuća (1. " + vocab.grade + " " + vocab.at + " " + vocab.mg +
                ")";
        }

        private void About_Load(object sender, EventArgs e)
        {
            RefreshVocab();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
