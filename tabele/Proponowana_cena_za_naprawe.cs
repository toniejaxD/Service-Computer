using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Proponowana_cena_za_naprawe
    {
        public string ID_cennik { get; set; }
        public string Nazwa_naprawy { get; set; }
        public double Cena_za_naprawe { get; set; }
        

        public string Klient_id_klienta { get; set; }

        public string Potwierdzenie_naprawy { get; set; }

        public DateTime Data_potwiedzenia { get; set; }

        public Proponowana_cena_za_naprawe(string id_cennik, string nazwa_naprawy, double cena_za_naprawe, string klient_id_klienta, string potwierdzenie_naprawy, DateTime data_potwierdzenia)
        {
            ID_cennik = id_cennik;
            Nazwa_naprawy = nazwa_naprawy;
            Cena_za_naprawe = cena_za_naprawe;
            Potwierdzenie_naprawy = potwierdzenie_naprawy;
            Data_potwiedzenia = data_potwierdzenia;
            Klient_id_klienta = klient_id_klienta;
        }
    }
}
