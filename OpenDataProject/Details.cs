using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OpenDataProject
{
    public partial class Details : Form
    {
        public Details(Skola skole)
        {
            InitializeComponent();
            this.skole = skole;
        }

        Skola skole;

        private void Details_Load(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = skole.www;
            LINK.Links.Add(link);
            ID.Text = skole.id.ToString();
            Vrsta.Text = skole.vrsta;
            Naziv.Text = skole.naziv;
            Telefon.Text = skole.tel;
            GPS.Text = skole.gps;
          //Text = skole.mesto;
          //Text = skole.okrug;
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
