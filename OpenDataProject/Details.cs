using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace OpenDataProject
{
    public partial class Details : Form
    {
        Skola skole;
        Vocab vocab;

        public Details(Skola skole)
        {
            InitializeComponent();
            this.skole = skole;
            RefreshVocab();
        }

        private void RefreshVocab()
        {
            vocab = Core.GetVocab();
            LabelAddress.Text = vocab.address;
            LabelControl.Text = vocab.control;
            LabelCounty.Text = vocab.county;
            LabelFax.Text = vocab.fax;
            LabelID.Text = vocab.id;
            LabelLocation.Text = vocab.location;
            LabelName.Text = vocab.name;
            LabelClasses.Text = vocab.numClasses;
            LabelPhone.Text = vocab.phone;
            LabelType.Text = vocab.type;
            LabelWebsite.Text = vocab.website;
        }

        private void Details_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = skole.www;
            LINK.Links.Add(link);
            Text = skole.naziv;
            ID.Text = skole.id.ToString();
            Vrsta.Text = skole.vrsta;
            Naziv.Text = skole.naziv;
            Telefon.Text = skole.tel;
            GPS.Text = skole.gps;
            Uprava.Text = skole.suprava;
            Faks.Text = skole.fax;
            Adresa.Text = skole.adresa;
            LINK.Text = skole.www;
            odeljenja.Text = skole.odeljenja.ToString();
            Okrug.Text = skole.okrug;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }
    }
}
