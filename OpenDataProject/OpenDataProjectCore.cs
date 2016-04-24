using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenDataProject
{
    static class OpenDataProjectCore
    {
        public static List<skola> Skole=new List<skola>();

        public static List<skola> GetFilter(string FilterKeyword)
        {
            //not fully implemented
            if (FilterKeyword == "All") return Skole;
            else if (FilterKeyword == "None") return new List<skola> { };
            else return Skole;
        }
    }

    class skola
    {
        public int ID;
        public string Ime;
        public string Adresa;
        public string PostanskiBroj;
        public string Mesto;
        public string Opstina;
        public string Okrug;
        public string SkolskaUprava;
        public string Sajt;
        public string Telefon;
        public string Fax;
        public string TipSkole;
        public int BrojOdeljenja;
        public double Lat;
        public double Lon;
        public string[] ToRow()
        {
            return (new string[] { ID.ToString(), Ime, Adresa, PostanskiBroj, Mesto, Opstina, Okrug, SkolskaUprava, Sajt, Telefon, Fax, TipSkole, BrojOdeljenja.ToString(), Lat.ToString(), Lon.ToString() });
        }
        public string ToString()
        {
            string s="";
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
        public skola(int IDa,string Imea,string Adresaa,string PostanskiBroja,string Mestoa,string Opstinaa,string Okruga,string SkolskaUpravaa,string Sajta,string Telefona,string Faxa,string TipSkolea,int BrojOdeljenjaa,double Lata,double Lona)
        {
            ID=IDa;
            Ime=Imea;
            Adresa=Adresaa;
            PostanskiBroj=PostanskiBroja;
            Mesto=Mestoa;
            Opstina=Opstinaa;
            Okrug=Okruga;
            SkolskaUprava=SkolskaUpravaa;
            Sajt=Sajta;
            Telefon=Telefona;
            Fax=Faxa;
            TipSkole=TipSkolea;
            BrojOdeljenja=BrojOdeljenjaa;
            Lat=Lata;
            Lon=Lona;
        }
        public skola(int IDa, string Imea, string Adresaa, string PostanskiBroja, string Mestoa, string Opstinaa, string Okruga, string SkolskaUpravaa, string Sajta, string Telefona,string tel,string tel2, string Faxa, string TipSkolea, int BrojOdeljenjaa, double Lata, double Lona)
        {
            ID = IDa;
            Ime = Imea;
            Adresa = Adresaa;
            PostanskiBroj = PostanskiBroja;
            Mesto = Mestoa;
            Opstina = Opstinaa;
            Okrug = Okruga;
            SkolskaUprava = SkolskaUpravaa;
            Sajt = Sajta;
            Telefon = Telefona;
            Fax = Faxa;
            TipSkole = TipSkolea;
            BrojOdeljenja = BrojOdeljenjaa;
            Lat = Lata;
            Lon = Lona;
        }

    }
}
