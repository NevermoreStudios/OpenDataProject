using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenDataProject
{
    class Skola
    {
        public string id, odeljenja, naziv, adresa, pbroj, mesto, opstina, okrug, suprava, www, tel, fax, vrsta,gps;
        public double Lat, Lon;

        public string[] ToRow()
        {
            return (new string[] { id.ToString(), naziv, adresa, pbroj, mesto, opstina, okrug, suprava, www, tel, fax, vrsta, odeljenja.ToString(), Lat.ToString(), Lon.ToString() });
        }


        public Skola(string ID, string Ime, string Adresa, string PostanskiBroj, string Mesto, string Opstina, string Okrug, string SkolskaUprava, string Sajt, string Telefon, string Fax, string TipSkole, string BrojOdeljenja, string Gps)
        {
            this.id = ID;
            this.naziv = Ime;
            this.adresa = Adresa;
            this.pbroj = PostanskiBroj;
            this.mesto = Mesto;
            this.opstina = Opstina;
            this.okrug = Okrug;
            this.suprava = SkolskaUprava;
            this.www = Sajt;
            this.tel = Telefon;
            this.fax = Fax;
            this.vrsta = TipSkole;
            this.odeljenja = BrojOdeljenja;
            this.gps = Gps;
            char[] del ={' ', ',',';'};
            string[] coords=Gps.Split(del,StringSplitOptions.RemoveEmptyEntries);
            try
            {
                this.Lat = double.Parse(coords[0]);
                this.Lon = double.Parse(coords[1]);
            }
            catch
            {
                try
                {
                    this.Lat = double.Parse(coords[0]);
                    this.Lon = double.Parse(coords[0]);
                }
                catch
                {
                    this.Lat = 0;
                    this.Lon = 0;
                }
            }
        }


    }
}
