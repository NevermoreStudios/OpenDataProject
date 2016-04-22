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
        
    }

    class skola
    {
        int ID;
        string Ime;
        string Adresa;
        string PostanskiBroj;
        string Mesto;
        string Opstina;
        string Okrug;
        string SkolskaUprava;
        string Sajt;
        string Telefon;
        string Fax;
        string TipSkole;
        int BrojOdeljenja;
        double Lat;
        double Lon;
        public string[] ToRow()
        {
            return (new string[]{ ID.ToString(), Ime, Adresa, PostanskiBroj, Mesto, Opstina, Okrug, SkolskaUprava, Sajt, Telefon, Fax, TipSkole, BrojOdeljenja.ToString(), Lat.ToString(), Lon.ToString() });
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
