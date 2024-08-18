using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Komputer
    {
        public string Numer_zlecenia_komputera { get; set; }

        public string Rodzaj_komputera { get; set; }
        public string Kolor_komputera { get; set; }

        public string Klient_id_klienta { get; set; }
        public string Uwagi_dla_klienta { get; set; }

        
        public string Proponowana_cena_za_naprawe_id_cennik { get; set; }



        public Komputer(string numer_zlecenia_komputera, string rodzaj_komputera, string kolor_komputera, string klient_id_klienta, string uwagi_dla_klienta,  string proponowana_cena_za_naprawe_id_cennik)
        {
            Numer_zlecenia_komputera = numer_zlecenia_komputera;
            
            Rodzaj_komputera = rodzaj_komputera;
            Kolor_komputera = kolor_komputera;
            Klient_id_klienta = klient_id_klienta;
            Uwagi_dla_klienta = uwagi_dla_klienta;
            Proponowana_cena_za_naprawe_id_cennik = proponowana_cena_za_naprawe_id_cennik;

        }
    }
}
