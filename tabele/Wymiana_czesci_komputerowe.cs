using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Wymiana_czesci_komputerowe
    {
        public string Wymiana_czesci_komputerowe1 { get; set; }
        public string Typ_czesci_komputerowe { get; set; }
        public double Cena_za_wymiane_czesci_komputerowe { get; set; }

        
         public string Historia_serwisu_id_naprawy_komputera { get; set; }

        public Wymiana_czesci_komputerowe(string wymiana_czesci_komputerowe1, string typ_czesci_komputerowe, double cena_za_wymiane_czesci_komputerowe, string historia_serwisu_id_naprawy_komputera)
        {
            Wymiana_czesci_komputerowe1 = wymiana_czesci_komputerowe1;
            Typ_czesci_komputerowe = typ_czesci_komputerowe;
            Cena_za_wymiane_czesci_komputerowe = cena_za_wymiane_czesci_komputerowe;
            Historia_serwisu_id_naprawy_komputera = historia_serwisu_id_naprawy_komputera;
        }
    }
}
