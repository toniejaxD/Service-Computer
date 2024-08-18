using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Rachunek
    {
        public string ID_rachunek { get; set; }
        public DateTime Data_rachunek { get; set; }
        public string Imie_klienta { get; set; }
        public string Nazwisko_klienta { get; set; }
       
        public string Identyfikator_rachunku { get; set; }
        public string Pracownik_id_pracownik { get; set; }
        public string Rodzaj_platnosci_id_platnosci { get; set; }

        public string Rodzaj_rachunku { get; set; }



        public Rachunek(string id_rachunek, DateTime data_rachunek, string imie_klienta, string nazwisko_klienta, string identyfikator_rachunku, string pracownik_id_pracownik, string rodzaj_platnosci_id_platnosci, string rodzaj_rachunku)
        {
            ID_rachunek = id_rachunek;
            Data_rachunek = data_rachunek;
            Imie_klienta = imie_klienta;
            Nazwisko_klienta = nazwisko_klienta;
            Pracownik_id_pracownik = pracownik_id_pracownik;
            Identyfikator_rachunku = identyfikator_rachunku;
            Rodzaj_platnosci_id_platnosci = rodzaj_platnosci_id_platnosci;
            Rodzaj_rachunku = rodzaj_rachunku;

        }
    }
}
