using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataProject
{
    class Skola
    {
        public int ID, BrojOdeljenja;
        public string Ime, Adresa, PostanskiBroj, Mesto, Opstina, Okrug, SkolskaUprava, Sajt, Telefon, Fax, TipSkole;
        public double Lat, Lon;

        public string[] ToRow()
        {
            return (new string[] { ID.ToString(), Ime, Adresa, PostanskiBroj, Mesto, Opstina, Okrug, SkolskaUprava, Sajt, Telefon, Fax, TipSkole, BrojOdeljenja.ToString(), Lat.ToString(), Lon.ToString() });
        }

        public override string ToString()
        {
            string s = "";
            string newline = "\r\n";
            s += "id:" + ID.ToString() + newline;
            s += "Ime:" + Ime + newline;
            s += "Adresa:" + Adresa + newline;
            s += "Postanski broj:" + PostanskiBroj + newline;
            s += "Mesto:" + Mesto + newline;
            s += "Opstina:" + Opstina + newline;
            s += "Okrug:" + Okrug + newline;
            s += "Skolska uprava:" + SkolskaUprava + newline;
            s += "Sajt:" + Sajt + newline;
            s += "Telefon:" + Telefon + newline;
            s += "Fax:" + Fax + newline;
            s += "Tip skole:" + TipSkole + newline;
            s += "Broj Odeljenja:" + BrojOdeljenja + newline;
            s += "Geografska sirina:" + Lat.ToString() + newline;
            s += "Geografska duzina:" + Lon.ToString() + newline;
            return s;
        }

        public Skola(int ID, string Ime, string Adresa, string PostanskiBroj, string Mesto, string Opstina, string Okrug, string SkolskaUprava, string Sajt, string Telefon, string Fax, string TipSkole, int BrojOdeljenja, double Lat, double Lon)
        {
            this.ID = ID;
            this.Ime = Ime;
            this.Adresa = Adresa;
            this.PostanskiBroj = PostanskiBroj;
            this.Mesto = Mesto;
            this.Opstina = Opstina;
            this.Okrug = Okrug;
            this.SkolskaUprava = SkolskaUprava;
            this.Sajt = Sajt;
            this.Telefon = Telefon;
            this.Fax = Fax;
            this.TipSkole = TipSkole;
            this.BrojOdeljenja = BrojOdeljenja;
            this.Lat = Lat;
            this.Lon = Lon;
        }

        public Skola(int ID, string Ime, string Adresa, string PostanskiBroj, string Mesto, string Opstina, string Okrug, string SkolskaUprava, string Sajt, string Telefon, string Djubre1, string Djubre2, string Fax, string TipSkole, int BrojOdeljenja, double Lat, double Lon)
        {
            new Skola(ID, Ime, Adresa, PostanskiBroj, Mesto, Opstina, Okrug, SkolskaUprava, Sajt, Telefon, Fax, TipSkole, BrojOdeljenja, Lat, Lon);
        }

    }
}
