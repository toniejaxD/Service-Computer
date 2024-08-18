using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Pracownik
    {
        public string ID_pracownik { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string Kontakty_id_kontakty { get; set; }
        
        public string Rachunek_id_rachunek { get; set; }

        public string Inna_cena_za_naprawe_id_inna_cena { get; set; }

        public Pracownik(string id_pracownik, string imie, string nazwisko, string kontakty_id_kontakty, string rachunek_id_rachunek, string inna_cena_za_naprawe_id_inna_cena)
        {
            ID_pracownik = id_pracownik;
            Imie = imie;
            Nazwisko = nazwisko;
            Kontakty_id_kontakty = kontakty_id_kontakty;
            Rachunek_id_rachunek = rachunek_id_rachunek;
            Inna_cena_za_naprawe_id_inna_cena = inna_cena_za_naprawe_id_inna_cena;
        }
    }
}
