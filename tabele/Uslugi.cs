using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Uslugi
    {
        public string ID_usługi { get; set; }
        public string Nazwa_uslugi { get; set; }
        public double Cena { get; set; }

        public string Historia_serwisu_id_naprawy_komputera { get; set; }


        public Uslugi(string id_usługi, string nazwa_uslugi, double cena, string historia_serwisu_id_naprawy_komputera)
        {
            ID_usługi = id_usługi;
            Nazwa_uslugi = nazwa_uslugi;
            Cena = cena;
            Historia_serwisu_id_naprawy_komputera = historia_serwisu_id_naprawy_komputera;

        }
    }
}
