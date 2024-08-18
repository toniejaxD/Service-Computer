using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Dostawca_czesci_komputerowe
    {
        public string ID_dostepnosc_czesci_komputerowe { get; set; }
        public string Ilosc_czesci_komputerowe { get; set; }
        public double Cena_za_dostawe_czesci_komputerowe { get; set; }
        public double Cena_za_czesc_komputerowe { get; set; }

        public Dostawca_czesci_komputerowe(string id_dostepnosc_czesci_komputerowe, string ilosc_czesci_komputerowe, double cena_za_dostawe_czesci_komputerowe, double cena_za_czesc_komputerowe) 
        {
            ID_dostepnosc_czesci_komputerowe = id_dostepnosc_czesci_komputerowe;
            Ilosc_czesci_komputerowe = ilosc_czesci_komputerowe;
            Cena_za_dostawe_czesci_komputerowe = cena_za_dostawe_czesci_komputerowe;
            Cena_za_czesc_komputerowe = cena_za_czesc_komputerowe;

        }

    }
}
