using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Klient
    {
        public string ID_klienta { get; set; }
        public string Imie { get; set; }

        public string Nazwisko { get; set; }
        public string Kontakty_id_kontakty { get; set; }

        public string Rodzaj_platnosci_id_platnosci { get; set; }
        public string Inna_cena_za_naprawe_id_inna_cena { get; set; }

        public Klient(string id_klienta, string imie, string nazwisko, string kontakty_id_kontakty, string rodzaj_platnosci_id_platnosci, string inna_cena_za_naprawe_id_inna_cena)
        {
            ID_klienta = id_klienta;
            Imie = imie;
            Nazwisko = nazwisko;
            Kontakty_id_kontakty = kontakty_id_kontakty;
            Rodzaj_platnosci_id_platnosci = rodzaj_platnosci_id_platnosci;
            Inna_cena_za_naprawe_id_inna_cena = inna_cena_za_naprawe_id_inna_cena;
        }
    }
}
