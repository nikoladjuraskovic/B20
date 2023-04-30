using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace B20
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        public class Valuta
        {
            private DateTime datum;
            private string oznaka;
            private double kurs;

            public Valuta() { }
            public Valuta(DateTime datum, string oznaka, double kurs)
            {
                this.datum = datum;
                this.oznaka = oznaka;
                this.kurs = kurs;
            }
            public DateTime Datum { get => datum; set => datum = value; }
            public string Oznaka { get => oznaka; set => oznaka = value; }
            public double Kurs { get => kurs; set => kurs = value; }

            public static List<Valuta> ucitajIzFajla(StreamReader r)
            {
                List<Valuta> sveValute = new List<Valuta>();
                while (!r.EndOfStream)
                {
                    string[] s = r.ReadLine().Split('|');
                    System.Diagnostics.Debug.WriteLine("Datum: " + s[0] + " Valuta: " + s[1] + " Vrednost: " + s[2]);                   
                    Valuta v = new Valuta(DateTime.Parse(s[0]), s[1], double.Parse(s[2]));
                    sveValute.Add(v);
                }
                return sveValute;
            }
        }

        [WebMethod]
        public List<string> ProcitajSveValute()
        {
            StreamReader r = new StreamReader(Server.MapPath("~/Kursevi/valute2.txt"));
            List<Valuta> listaValuta = Valuta.ucitajIzFajla(r);
            r.Close();
            List<string> sveOznake = new List<string>();
            foreach (Valuta x in listaValuta)
            {
                if (!sveOznake.Contains(x.Oznaka))
                    sveOznake.Add(x.Oznaka);
            }
            return sveOznake;
        }

        [WebMethod]
        public double ProcitajKursNaDan(DateTime Datum, string valuta)
        {
            StreamReader r = new StreamReader(Server.MapPath("~/Kursevi/valute2.txt"));
            List<Valuta> listaValuta = Valuta.ucitajIzFajla(r);
            r.Close();
            foreach (Valuta x in listaValuta)
            {
                if (x.Datum == Datum && x.Oznaka == valuta)
                    return x.Kurs;
            }
            return 0;
        }
        [WebMethod]
        public bool UpisiKursNaDan(DateTime Datum, string valuta, double Kurs)
        {
            string upis = Datum.Date.ToString("M.d.yyyy") + "|" + valuta + "|" + Kurs + "\n";
            File.AppendAllText(Server.MapPath("~/Kursevi/valute2.txt"), upis);
            return true;
        }
    }
}
