using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Rodzaj_platnosci
    {
        public string ID_platnosci { get; set; }
        
        public string Rodzaj_platnoscii { get; set; }
        public double Koszt { get; set; }

        public string Klient_id_klienta { get; set; }

        public string Rachunek_id_rachunek { get; set; }



        public Rodzaj_platnosci(string id_platnosci, string rodzaj_platnosci, double koszt,string klient_id_klienta, string rachunek_id_rachunek) 
        { 
            ID_platnosci = id_platnosci;
            Rodzaj_platnoscii = rodzaj_platnosci;
            Koszt = koszt;
            Klient_id_klienta = klient_id_klienta;
            Rachunek_id_rachunek = rachunek_id_rachunek;
        }
    }
}
