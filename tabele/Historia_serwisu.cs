using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Historia_serwisu
    {

        public string ID_naprawy_komputera { get; set; }
        public DateTime Data_naprawy { get; set; }
        public double Cena_za_naprawe { get; set; }
        
        public string Komputer_numer_zlecenia_komputera { get; set; }

        public Historia_serwisu(string id_naprawy_komputera, DateTime data_naprawy, double cena_za_naprawe, string komputer_numer_zlecenia_komputera)
        {
            ID_naprawy_komputera = id_naprawy_komputera;
            Data_naprawy = data_naprawy;
            Cena_za_naprawe = cena_za_naprawe;
            Komputer_numer_zlecenia_komputera = komputer_numer_zlecenia_komputera;

        }
    }
}
