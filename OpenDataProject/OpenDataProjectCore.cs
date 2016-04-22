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
        public static List<string> Skoles =new List<string>();
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
        int Lat;
        int Lon;
        public skola(int ID,string Ime,string Adresa,string PostanskiBroj,string Mesto,string Opstina,string Okrug,string SkolskaUprava,string Sajt,string Telefon,string Fax,string TipSkole,int BrojOdeljenja,int Lat,int Lon)
        {
            ID=ID;
            Ime=Ime;
            Adresa=Adresa;
            PostanskiBroj=PostanskiBroj;
            Mesto=Mesto;
            Opstina=Opstina;
            Okrug=Okrug;
            SkolskaUprava=SkolskaUprava;
            Sajt=Sajt;
            Telefon=Telefon;
            Fax=Fax;
            TipSkole=TipSkole;
            BrojOdeljenja=BrojOdeljenja;
            Lat=Lat;
            Lon=Lon;
        }
    }
}
