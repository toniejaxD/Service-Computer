using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generowanieserwis.tabele
{
    internal class Kontakty
    {
        public string ID_kontakty { get; set; }
        public string Numer_telefonu_klienta { get; set; }
        public string Numer_telefonu_pracownika { get; set; }
        public string Email_klienta { get; set; }
        public string Email_pracownika { get; set; }

        public string Klient_id_klienta { get; set; }

        public string Pracownik_id_pracownik { get; set; }

        public Kontakty(string id_kontakty, string numer_telefonu_klienta, string numer_telefonu_pracownika, string email_klienta, string email_pracownika, string klient_id_klienta, string pracownik_id_pracownik)
        {
            ID_kontakty = id_kontakty;
            Numer_telefonu_klienta = numer_telefonu_klienta;
            Numer_telefonu_pracownika = numer_telefonu_pracownika;
            Email_klienta = email_klienta;
            Email_pracownika = email_pracownika;
            Klient_id_klienta = klient_id_klienta;
            Pracownik_id_pracownik = pracownik_id_pracownik;
        }
    }
}
