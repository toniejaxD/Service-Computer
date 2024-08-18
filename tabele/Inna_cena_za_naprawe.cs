using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Inna_cena_za_naprawe
    {
        public string ID_inna_cena { get; set; }
        public double Cena_za_cala_naprawe { get; set; }
        public string Potwierdzenie_innej_innej { get; set; }
       
        public DateTime Data_potwierdzenia { get; set; }
        public string Pracownik_id_pracownik { get; set; }


        public Inna_cena_za_naprawe(string id_inna_cena, double cena_za_cala_naprawe, string potwierdzenie_innej_innej, DateTime data_potwierdzenia, string pracownik_id_pracownik)
        {
            ID_inna_cena = id_inna_cena;
            Cena_za_cala_naprawe = cena_za_cala_naprawe;
            Potwierdzenie_innej_innej = potwierdzenie_innej_innej;
            Data_potwierdzenia = data_potwierdzenia;
            Pracownik_id_pracownik = pracownik_id_pracownik;


        }
    }
}
